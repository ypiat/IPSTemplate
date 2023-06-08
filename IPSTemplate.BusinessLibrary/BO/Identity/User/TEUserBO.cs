using System.ComponentModel.DataAnnotations;
using Core.DAL.Infrastructure;
using Core.Library.Base;
using Csla;
using Csla.Core;
using Csla.Rules;
using IPSTemplate.BusinessLibrary.BO.Identity.UserRole;

namespace IPSTemplate.BusinessLibrary.BO.Identity.User
{
    [Serializable]
    public class TEUserBO : CslaBusinessBase<TEUserBO, Entity>
    {
        #region Properties

        public static readonly PropertyInfo<string> UsernameProperty = RegisterProperty<string>(p => p.Username);
        [LocalizedStringLength(256)]
        ////[Display(ResourceType = typeof(Properties.Resources), Name = nameof(User_Email))]
        [RegularExpression(RegularExpressions.Email.EmailAddress, ErrorMessage = "Neveljaven e-poštni vzorec (example@example.com)")]
        public string Username
        {
            get => GetProperty(UsernameProperty);
            set => SetProperty(UsernameProperty, value); 
        }

        public static readonly PropertyInfo<string> EmailProperty = RegisterProperty<string>(p => p.Email);
        [Required]
        [LocalizedStringLength(256)]
        [Display(Name = "Email")]
        ////[Display(ResourceType = typeof(Properties.Resources), Name = nameof(User_Email))]
        [RegularExpression(RegularExpressions.Email.EmailAddress, ErrorMessage = "Neveljaven e-poštni vzorec (example@example.com)")]
        public string Email
        {
            get => GetProperty(EmailProperty);
            set
            {
                SetProperty(EmailProperty, value); 
                SetProperty(UsernameProperty, value); //Email is username
            }
        }

        public static readonly PropertyInfo<string> PhoneNumberProperty = RegisterProperty<string>(p => p.PhoneNumber);
        [LocalizedStringLength(256)]
        ////[Display(ResourceType = typeof(Properties.Resources), Name = nameof(User_PhoneNumber))]
        [RegularExpression(RegularExpressions.Phone.PhoneNumber)]
        public string PhoneNumber
        {
            get => GetProperty(PhoneNumberProperty);
            set => SetProperty(PhoneNumberProperty, value);
        }

        public static readonly PropertyInfo<bool> EmailConfirmedProperty = RegisterProperty<bool>(p => p.EmailConfirmed);
        ////[Display(ResourceType = typeof(Properties.Resources), Name = nameof(User_EmailConfirmed))]
        public bool EmailConfirmed
        {
            get => GetProperty(EmailConfirmedProperty);
            set => SetProperty(EmailConfirmedProperty, value);
        }

        public static readonly PropertyInfo<bool> PhoneNumberConfirmedProperty = RegisterProperty<bool>(p => p.PhoneNumberConfirmed);
        ////[Display(ResourceType = typeof(Properties.Resources), Name = nameof(User_PhoneNumberConfirmed))]
        public bool PhoneNumberConfirmed
        {
            get => GetProperty(PhoneNumberConfirmedProperty);
            set => SetProperty(PhoneNumberConfirmedProperty, value);
        }

        public static readonly PropertyInfo<string> NameProperty = RegisterProperty<string>(p => p.Name);
        [Required(ErrorMessage = "Polje z imenom je obvezno")]
        [LocalizedStringLength(100, 2)]
        [Display(Name = "Ime")]
        ////[Display(ResourceType = typeof(Properties.Resources), Name = nameof(User_Name))]
        public string Name
        {
            get => GetProperty(NameProperty);
            set => SetProperty(NameProperty, value);
        }

        public static readonly PropertyInfo<string> SurnameProperty = RegisterProperty<string>(p => p.Surname);
        [Required(ErrorMessage = "Polje z priimkom je obvezno")]
        [LocalizedStringLength(100, 2)]
        [Display(Name = "Priimek")]
        //[Display(ResourceType = typeof(Properties.Resources), Name = nameof(User_Surname))]
        public string Surname
        {
            get => GetProperty(SurnameProperty);
            set => SetProperty(SurnameProperty, value);
        }

        [Display(Name = "Uporabnik")]
        public string DisplayName
        {
            get => $"{Name} {Surname}".Trim();
        }

        //[Display(ResourceType = typeof(Properties.Resources), Name = nameof(User_Active))]
        public new bool Active
        {
            get => GetProperty(ActiveProperty);
            set => SetProperty(ActiveProperty, value);
        }

        public static readonly PropertyInfo<Guid?> SupplierIDProperty = RegisterProperty<Guid?>(p => p.SupplierID);
        //[Display(ResourceType = typeof(Properties.Resources), Name = nameof(User_Supplier))]
        public Guid? SupplierID
        {
            get => GetProperty(SupplierIDProperty);
            set => SetProperty(SupplierIDProperty, value);
        }

        public static readonly PropertyInfo<MobileList<string>> UserRolesProperty = RegisterProperty<MobileList<string>>(p => p.UserRoles);
        //[Display(ResourceType = typeof(Properties.Resources), Name = nameof(User_UserRoles))]
        public MobileList<string> UserRoles
        {
            get => GetProperty(UserRolesProperty);
            set => SetProperty(UserRolesProperty, value);
        }

        //[Display(ResourceType = typeof(Properties.Resources), Name = nameof(User_UserRoles))]
        public List<string> UserRolesList
        {
            get { return (List<string>)UserRoles; }
            set { UserRoles = new MobileList<string>(value); }
        }

        public static readonly PropertyInfo<bool> SkipUsernameCheckProperty = RegisterProperty<bool>(p => p.SkipUsernameCheck);
        /// <summary>
        /// Non-persistent!
        /// </summary>
        public bool SkipUsernameCheck
        {
            get => GetProperty(SkipUsernameCheckProperty);
            set => SetProperty(SkipUsernameCheckProperty, value);
        }

        public static readonly PropertyInfo<DateTime?> DateOfBirthProperty = RegisterProperty<DateTime?>(p => p.DateOfBirth);
        [Display(Name = "Datum rojstva")]
        public DateTime? DateOfBirth
        {
            get => GetProperty(DateOfBirthProperty);
            set => SetProperty(DateOfBirthProperty, value);
        }
        #endregion

        #region Validation rules

        protected override void AddBusinessRules()
        {
            base.AddBusinessRules();
            BusinessRules.AddDataAnnotations();

            BusinessRules.AddRule(new UsernameUniqueAsync(UsernameProperty, IdProperty, SkipUsernameCheckProperty));

            BusinessRules.AddRule(new IsYearInRightRange(DateOfBirthProperty));
        }

        private class UsernameUniqueAsync : BusinessRuleAsync
        {
            public UsernameUniqueAsync(IPropertyInfo usernameProperty, IPropertyInfo idProperty, IPropertyInfo skipCheckProperty) : base(usernameProperty)
            {
                InputProperties.Add(PrimaryProperty);
                InputProperties.Add(idProperty);
                InputProperties.Add(skipCheckProperty);
                ProvideTargetWhenAsync = true;
            }

            protected override async Task ExecuteAsync(IRuleContext context)
            {
                var id = context.GetInputValue(IdProperty);
                var username = context.GetInputValue(UsernameProperty);
                var skipCheck = context.GetInputValue(SkipUsernameCheckProperty);

                if (skipCheck || !(context.Target as TEUserBO).IsDirty || (username?.Length ?? 0) < 6) //min valid email = x@y.zz, not checking if not dirty
                    return;

                var request = await context.DataPortalFactory.GetPortal<MobileCslaRequest>().CreateAsync();
                var usernameFilter = await CslaRequestFilter.CreateNewFilterAsync(nameof(TEUserInfo.Username), typeof(string), 2, username, context.DataPortalFactory.GetPortal<CslaRequestFilter>());
                request.Filters.Add(usernameFilter);

                var existingUsers = await TEUserRL.GetListAsync(request, context.DataPortalFactory, false);
                if (existingUsers.Any(u => u.Id != id))
                    context.AddErrorResult("This username already exists");
            }
        }

        private class IsYearInRightRange : BusinessRule
        {
            public IsYearInRightRange(Csla.Core.IPropertyInfo DateOfBirthProperty) : base(DateOfBirthProperty)
            {
                InputProperties.Add(PrimaryProperty);
            }

            protected override void Execute(IRuleContext context)
            {
                DateTime? DateOfBirth = DateTime.Now;
                if (!context.TryGetInputValue(PrimaryProperty, ref DateOfBirth))
                {
                    return;
                }

                if (DateOfBirth > DateTime.Now.AddYears(-16) || DateOfBirth < DateTime.Now.AddYears(-100))
                {
                    context.AddErrorResult($"Leto mora biti v območju {DateTime.Now.AddYears(-100).Year.ToString()} - {DateTime.Now.AddYears(-16).Year.ToString()}");
                }
            }
        }

        #endregion

        #region Client-side methods

        public static new TEUserBO GetItem(Guid Id, IDataPortalFactory factory) => TEUserGetCommand.GetUser(Id, factory);

        public static new async Task<TEUserBO> GetItemAsync(Guid Id, IDataPortalFactory factory) => await TEUserGetCommand.GetUserAsync(Id, factory);

        protected override async Task<TEUserBO> SaveAsync(bool forceUpdate, object userState, bool isSync)
        {
            if (isSync)
            {
                TEUserSaveCommand.SaveUser(this, ApplicationContext.GetRequiredService<IDataPortalFactory>());
                TEUserRoleSaveListCommand.SaveUserRolesList(Id, UserRoles, ApplicationContext.GetRequiredService<IDataPortalFactory>());
                TEUserLogoutCommand.LogUserOut(Id, ApplicationContext.GetRequiredService<IDataPortalFactory>());
            }
            else
            {
                await TEUserSaveCommand.SaveUserAsync(this, ApplicationContext.GetRequiredService<IDataPortalFactory>());
                await TEUserRoleSaveListCommand.SaveUserRolesListAsync(Id, UserRoles, ApplicationContext.GetRequiredService<IDataPortalFactory>());
                await TEUserLogoutCommand.LogUserOutAsync(Id, ApplicationContext.GetRequiredService<IDataPortalFactory>());
            }
            Mark_Clean();
            MarkOld();
            return this;
        }

        public new void MarkOld()
        {
            base.MarkOld();
        }

        public static async Task<List<string>> GetAllUserRoles(IDataPortalFactory factory)
        {
            return await TEUserRoleGetListCommand.GetAllUserRolesAsync(factory);
        }

        protected static async Task CreateNewRoleAsync(string roleName, IDataPortalFactory factory)
        {
            await TEUserRoleCreateCommand.CreateNewRoleAsync(roleName, factory);
        }

        //protected override void Create()
        //{
        //    Username = Email;
        //    base.Create();
        //}

        //protected override Task CreateAsync(bool isAsync)
        //{
        //    Username = Email;
        //    return base.CreateAsync(isAsync);
        //}

        #endregion

        #region Server-side methods

        [RunLocal, Create]
        protected override void Create()
        {
            base.Create();
            Active = true;
            UserRoles = new MobileList<string>();
        }

        [RunLocal, Create]
        protected override async Task CreateAsync(bool isAsync)
        {
            await base.CreateAsync(isAsync);
            Active = true;
            UserRoles = new MobileList<string>();
        }

        #endregion
    }
}
