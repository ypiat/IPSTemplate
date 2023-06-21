using Core.Library.Security;
using Csla.Rules.CommonRules;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System;
using Microsoft.VisualBasic;
using Core.DALEF.ContextFactory.Seeds;
using NetTopologySuite.Algorithm;
using NetTopologySuite.Triangulate.QuadEdge;
using System.Text;

namespace IPSTemplate.BusinessLibrary.StandardCollections;

public class TECountries
{
    public const string AF = " AF  ";
    public const string AL  = " AL  ";
    public const string DZ  = " DZ  ";
    public const string AD  = " AD  ";
    public const string AO  = " AO  ";
    public const string AG  = " AG  ";
    public const string AR  = " AR  ";
    public const string AM  = " AM  ";
    public const string AU  = " AU  ";
    public const string AT  = " AT  ";
    public const string AZ  = " AZ  ";
    public const string BS  = " BS  ";
    public const string BH  = " BH  ";
    public const string BD  = " BD  ";
    public const string BB  = " BB  ";
    public const string BY  = " BY  ";
    public const string BE  = " BE  ";
    public const string BZ  = " BZ  ";
    public const string BJ  = " BJ  ";
    public const string BT  = " BT  ";
    public const string BO  = " BO  ";
    public const string BA  = " BA  ";
    public const string BW  = " BW  ";
    public const string BR  = " BR  ";
    public const string BN  = " BN  ";
    public const string BG  = " BG  ";
    public const string BF  = " BF  ";
    public const string BI  = " BI  ";
    public const string CV  = " CV  ";
    public const string KH  = " KH  ";
    public const string CM  = " CM  ";
    public const string CA  = " CA  ";
    public const string CF  = " CF  ";
    public const string TD  = " TD  ";
    public const string CL  = " CL  ";
    public const string CN  = " CN  ";
    public const string CO  = " CO  ";
    public const string KM  = " KM  ";
    public const string CG  = " CG  ";
    public const string CR  = " CR  ";
    public const string CI  = " CI  ";
    public const string HR  = " HR  ";
    public const string CU  = " CU  ";
    public const string CY  = " CY  ";
    public const string CZ  = " CZ  ";
    public const string CD  = " CD  ";
    public const string DK  = " DK  ";
    public const string DJ  = " DJ  ";
    public const string DM  = " DM  ";
    public const string DO  = " DO  ";
    public const string EC  = " EC  ";
    public const string EG  = " EG  ";
    public const string SV  = " SV  ";
    public const string GQ  = " GQ  ";
    public const string ER  = " ER  ";
    public const string EE  = " EE  ";
    public const string SZ  = " SZ  ";
    public const string ET  = " ET  ";
    public const string FJ  = " FJ  ";
    public const string FI  = " FI  ";
    public const string FR  = " FR  ";
    public const string GA  = " GA  ";
    public const string GM  = " GM  ";
    public const string GE  = " GE  ";
    public const string DE  = " DE  ";
    public const string GH  = " GH  ";
    public const string GR  = " GR  ";
    public const string GD  = " GD  ";
    public const string GT  = " GT  ";
    public const string GN  = " GN  ";
    public const string GW  = " GW  ";
    public const string GY  = " GY  ";
    public const string HT  = " HT  ";
    public const string VA  = " VA  ";
    public const string HN  = " HN  ";
    public const string HU  = " HU  ";
    public const string IS  = " IS  ";
    public const string IN  = " IN  ";
    public const string ID  = " ID  ";
    public const string IR  = " IR  ";
    public const string IQ  = " IQ  ";
    public const string IE  = " IE  ";
    public const string IL  = " IL  ";
    public const string IT  = " IT  ";
    public const string JM  = " JM  ";
    public const string JP  = " JP  ";
    public const string JO  = " JO  ";
    public const string KZ  = " KZ  ";
    public const string KE  = " KE  ";
    public const string KI  = " KI  ";
    public const string KW  = " KW  ";
    public const string KG  = " KG  ";
    public const string LA  = " LA  ";
    public const string LV  = " LV  ";
    public const string LB  = " LB  ";
    public const string LS  = " LS  ";
    public const string LR  = " LR  ";
    public const string LY  = " LY  ";
    public const string LI  = " LI  ";
    public const string LT  = " LT  ";
    public const string LU  = " LU  ";
    public const string MK  = " MK  ";
    public const string MG  = " MG  ";
    public const string MW  = " MW  ";
    public const string MY  = " MY  ";
    public const string MV  = " MV  ";
    public const string ML  = " ML  ";
    public const string MT  = " MT  ";
    public const string MH  = " MH  ";
    public const string MR  = " MR  ";
    public const string MU  = " MU  ";
    public const string MX  = " MX  ";
    public const string FM  = " FM  ";
    public const string MD  = " MD  ";
    public const string MC  = " MC  ";
    public const string MN  = " MN  ";
    public const string ME  = " ME  ";
    public const string MA  = " MA  ";
    public const string MZ  = " MZ  ";
    public const string MM  = " MM  ";
    public const string NA  = " NA  ";
    public const string NR  = " NR  ";
    public const string NP  = " NP  ";
    public const string NL  = " NL  ";
    public const string NZ  = " NZ  ";
    public const string NI  = " NI  ";
    public const string NE  = " NE  ";
    public const string NG  = " NG  ";
    public const string KP  = " KP  ";
    public const string NO  = " NO  ";
    public const string OM  = " OM  ";
    public const string PK  = " PK  ";
    public const string PW  = " PW  ";
    public const string PS  = " PS  ";
    public const string PA  = " PA  ";
    public const string PG  = " PG  ";
    public const string PY  = " PY  ";
    public const string PE  = " PE  ";
    public const string PH  = " PH  ";
    public const string PL  = " PL  ";
    public const string PT  = " PT  ";
    public const string QA  = " QA  ";
    public const string RO  = " RO  ";
    public const string RU  = " RU  ";
    public const string RW  = " RW  ";
    public const string KN  = " KN  ";
    public const string LC  = " LC  ";
    public const string VC  = " VC  ";
    public const string WS  = " WS  ";
    public const string SM  = " SM  ";
    public const string ST  = " ST  ";
    public const string SA  = " SA  ";
    public const string SN  = " SN  ";
    public const string CS  = " CS  ";
    public const string SC  = " SC  ";
    public const string SL  = " SL  ";
    public const string SG  = " SG  ";
    public const string SK  = " SK  ";
    public const string SI  = " SI  ";
    public const string SB  = " SB  ";
    public const string SO  = " SO  ";
    public const string ZA  = " ZA  ";
    public const string KR  = " KR  ";
    public const string SS  = " SS  ";
    public const string ES  = " ES  ";
    public const string LK  = " LK  ";
    public const string SD  = " SD  ";
    public const string SR  = " SR  ";
    public const string SE  = " SE  ";
    public const string CH  = " CH  ";
    public const string SY  = " SY  ";
    public const string TJ  = " TJ  ";
    public const string TZ  = " TZ  ";
    public const string TH  = " TH  ";
    public const string TL  = " TL  ";
    public const string TG  = " TG  ";
    public const string TO  = " TO  ";
    public const string TT  = " TT  ";
    public const string TN  = " TN  ";
    public const string TR  = " TR  ";
    public const string TM  = " TM  ";
    public const string TV  = " TV  ";
    public const string UG  = " UG  ";
    public const string UA  = " UA  ";
    public const string AE  = " AE  ";
    public const string GB  = " GB  ";
    public const string US  = " US  ";
    public const string UY  = " UY  ";
    public const string UZ  = " UZ  ";
    public const string VU  = " VU  ";
    public const string VE  = " VE  ";
    public const string VN  = " VN  ";
    public const string YE  = " YE  ";
    public const string ZM  = " ZM  ";
    public const string ZW  = " ZW  ";

   
    public static List<string> All => new()
    {
        AF  ,
        AL  ,
        DZ  ,
        AD  ,
        AO  ,
        AG  ,
        AR  ,
        AM  ,
        AU  ,
        AT  ,
        AZ  ,
        BS  ,
        BH  ,
        BD  ,
        BB  ,
        BY  ,
        BE  ,
        BZ  ,
        BJ  ,
        BT  ,
        BO  ,
        BA  ,
        BW  ,
        BR  ,
        BN  ,
        BG  ,
        BF  ,
        BI  ,
        CV  ,
        KH  ,
        CM  ,
        CA  ,
        CF  ,
        TD  ,
        CL  ,
        CN  ,
        CO  ,
        KM  ,
        CG  ,
        CR  ,
        CI  ,
        HR  ,
        CU  ,
        CY  ,
        CZ  ,
        CD  ,
        DK  ,
        DJ  ,
        DM  ,
        DO  ,
        EC  ,
        EG  ,
        SV  ,
        GQ  ,
        ER  ,
        EE  ,
        SZ  ,
        ET  ,
        FJ  ,
        FI  ,
        FR  ,
        GA  ,
        GM  ,
        GE  ,
        DE  ,
        GH  ,
        GR  ,
        GD  ,
        GT  ,
        GN  ,
        GW  ,
        GY  ,
        HT  ,
        VA  ,
        HN  ,
        HU  ,
        IS  ,
        IN  ,
        ID  ,
        IR  ,
        IQ  ,
        IE  ,
        IL  ,
        IT  ,
        JM  ,
        JP  ,
        JO  ,
        KZ  ,
        KE  ,
        KI  ,
        KW  ,
        KG  ,
        LA  ,
        LV  ,
        LB  ,
        LS  ,
        LR  ,
        LY  ,
        LI  ,
        LT  ,
        LU  ,
        MK  ,
        MG  ,
        MW  ,
        MY  ,
        MV  ,
        ML  ,
        MT  ,
        MH  ,
        MR  ,
        MU  ,
        MX  ,
        FM  ,
        MD  ,
        MC  ,
        MN  ,
        ME  ,
        MA  ,
        MZ  ,
        MM  ,
        NA  ,
        NR  ,
        NP  ,
        NL  ,
        NZ  ,
        NI  ,
        NE  ,
        NG  ,
        KP  ,
        NO  ,
        OM  ,
        PK  ,
        PW  ,
        PS  ,
        PA  ,
        PG  ,
        PY  ,
        PE  ,
        PH  ,
        PL  ,
        PT  ,
        QA  ,
        RO  ,
        RU  ,
        RW  ,
        KN  ,
        LC  ,
        VC  ,
        WS  ,
        SM  ,
        ST  ,
        SA  ,
        SN  ,
        CS  ,
        SC  ,
        SL  ,
        SG  ,
        SK  ,
        SI  ,
        SB  ,
        SO  ,
        ZA  ,
        KR  ,
        SS  ,
        ES  ,
        LK  ,
        SD  ,
        SR  ,
        SE  ,
        CH  ,
        SY  ,
        TJ  ,
        TZ  ,
        TH  ,
        TL  ,
        TG  ,
        TO  ,
        TT  ,
        TN  ,
        TR  ,
        TM  ,
        TV  ,
        UG  ,
        UA  ,
        AE  ,
        GB  ,
        US  ,
        UY  ,
        UZ  ,
        VU  ,
        VE  ,
        VN  ,
        YE  ,
        ZM  ,
        ZW  ,
    };

    public static Dictionary<string, string> OrderedUserFriendlyNameMap => new Dictionary<string, string>
    {
        { AF  , GetUserFriendlyName( AF  ) },
        { AL , GetUserFriendlyName( AL ) },
        { DZ  , GetUserFriendlyName( DZ  ) },
        { AD , GetUserFriendlyName( AD ) },
        { AO  , GetUserFriendlyName( AO  ) },
        { AG , GetUserFriendlyName( AG ) },
        { AR  , GetUserFriendlyName( AR  ) },
        { AM , GetUserFriendlyName( AM ) },
        { AU  , GetUserFriendlyName( AU  ) },
        { AT , GetUserFriendlyName( AT ) },
        { AZ  , GetUserFriendlyName( AZ  ) },
        { BS , GetUserFriendlyName( BS ) },
        { BH  , GetUserFriendlyName( BH  ) },
        { BD , GetUserFriendlyName( BD ) },
        { BB  , GetUserFriendlyName( BB  ) },
        { BY , GetUserFriendlyName( BY ) },
        { BE  , GetUserFriendlyName( BE  ) },
        { BZ , GetUserFriendlyName( BZ ) },
        { BJ  , GetUserFriendlyName( BJ  ) },
        { BT , GetUserFriendlyName( BT ) },
        { BO  , GetUserFriendlyName( BO  ) },
        { BA , GetUserFriendlyName( BA ) },
        { BW  , GetUserFriendlyName( BW  ) },
        { BR , GetUserFriendlyName( BR ) },
        { BN  , GetUserFriendlyName( BN  ) },
        { BG , GetUserFriendlyName( BG ) },
        { BF  , GetUserFriendlyName( BF  ) },
        { BI , GetUserFriendlyName( BI ) },
        { CV  , GetUserFriendlyName( CV  ) },
        { KH , GetUserFriendlyName( KH ) },
        { CM  , GetUserFriendlyName( CM  ) },
        { CA , GetUserFriendlyName( CA ) },
        { CF  , GetUserFriendlyName( CF  ) },
        { TD , GetUserFriendlyName( TD ) },
        { CL  , GetUserFriendlyName( CL  ) },
        { CN , GetUserFriendlyName( CN ) },
        { CO  , GetUserFriendlyName( CO  ) },
        { KM , GetUserFriendlyName( KM ) },
        { CG  , GetUserFriendlyName( CG  ) },
        { CR , GetUserFriendlyName( CR ) },
        { CI  , GetUserFriendlyName( CI  ) },
        { HR , GetUserFriendlyName( HR ) },
        { CU  , GetUserFriendlyName( CU  ) },
        { CY , GetUserFriendlyName( CY ) },
        { CZ  , GetUserFriendlyName( CZ  ) },
        { CD , GetUserFriendlyName( CD ) },
        { DK  , GetUserFriendlyName( DK  ) },
        { DJ , GetUserFriendlyName( DJ ) },
        { DM  , GetUserFriendlyName( DM  ) },
        { DO , GetUserFriendlyName( DO ) },
        { EC  , GetUserFriendlyName( EC  ) },
        { EG , GetUserFriendlyName( EG ) },
        { SV  , GetUserFriendlyName( SV  ) },
        { GQ , GetUserFriendlyName( GQ ) },
        { ER  , GetUserFriendlyName( ER  ) },
        { EE , GetUserFriendlyName( EE ) },
        { SZ  , GetUserFriendlyName( SZ  ) },
        { ET , GetUserFriendlyName( ET ) },
        { FJ  , GetUserFriendlyName( FJ  ) },
        { FI , GetUserFriendlyName( FI ) },
        { FR  , GetUserFriendlyName( FR  ) },
        { GA , GetUserFriendlyName( GA ) },
        { GM  , GetUserFriendlyName( GM  ) },
        { GE , GetUserFriendlyName( GE ) },
        { DE  , GetUserFriendlyName( DE  ) },
        { GH , GetUserFriendlyName( GH ) },
        { GR  , GetUserFriendlyName( GR  ) },
        { GD , GetUserFriendlyName( GD ) },
        { GT  , GetUserFriendlyName( GT  ) },
        { GN , GetUserFriendlyName( GN ) },
        { GW  , GetUserFriendlyName( GW  ) },
        { GY , GetUserFriendlyName( GY ) },
        { HT  , GetUserFriendlyName( HT  ) },
        { VA , GetUserFriendlyName( VA ) },
        { HN  , GetUserFriendlyName( HN  ) },
        { HU , GetUserFriendlyName( HU ) },
        { IS  , GetUserFriendlyName( IS  ) },
        { IN , GetUserFriendlyName( IN ) },
        { ID  , GetUserFriendlyName( ID  ) },
        { IR , GetUserFriendlyName( IR ) },
        { IQ  , GetUserFriendlyName( IQ  ) },
        { IE , GetUserFriendlyName( IE ) },
        { IL  , GetUserFriendlyName( IL  ) },
        { IT , GetUserFriendlyName( IT ) },
        { JM  , GetUserFriendlyName( JM  ) },
        { JP , GetUserFriendlyName( JP ) },
        { JO  , GetUserFriendlyName( JO  ) },
        { KZ , GetUserFriendlyName( KZ ) },
        { KE  , GetUserFriendlyName( KE  ) },
        { KI , GetUserFriendlyName( KI ) },
        { KW  , GetUserFriendlyName( KW  ) },
        { KG , GetUserFriendlyName( KG ) },
        { LA  , GetUserFriendlyName( LA  ) },
        { LV , GetUserFriendlyName( LV ) },
        { LB  , GetUserFriendlyName( LB  ) },
        { LS , GetUserFriendlyName( LS ) },
        { LR  , GetUserFriendlyName( LR  ) },
        { LY , GetUserFriendlyName( LY ) },
        { LI  , GetUserFriendlyName( LI  ) },
        { LT , GetUserFriendlyName( LT ) },
        { LU  , GetUserFriendlyName( LU  ) },
        { MK , GetUserFriendlyName( MK ) },
        { MG  , GetUserFriendlyName( MG  ) },
        { MW , GetUserFriendlyName( MW ) },
        { MY  , GetUserFriendlyName( MY  ) },
        { MV , GetUserFriendlyName( MV ) },
        { ML  , GetUserFriendlyName( ML  ) },
        { MT , GetUserFriendlyName( MT ) },
        { MH  , GetUserFriendlyName( MH  ) },
        { MR , GetUserFriendlyName( MR ) },
        { MU  , GetUserFriendlyName( MU  ) },
        { MX , GetUserFriendlyName( MX ) },
        { FM  , GetUserFriendlyName( FM  ) },
        { MD , GetUserFriendlyName( MD ) },
        { MC  , GetUserFriendlyName( MC  ) },
        { MN , GetUserFriendlyName( MN ) },
        { ME  , GetUserFriendlyName( ME  ) },
        { MA , GetUserFriendlyName( MA ) },
        { MZ  , GetUserFriendlyName( MZ  ) },
        { MM , GetUserFriendlyName( MM ) },
        { NA  , GetUserFriendlyName( NA  ) },
        { NR , GetUserFriendlyName( NR ) },
        { NP  , GetUserFriendlyName( NP  ) },
        { NL , GetUserFriendlyName( NL ) },
        { NZ  , GetUserFriendlyName( NZ  ) },
        { NI , GetUserFriendlyName( NI ) },
        { NE  , GetUserFriendlyName( NE  ) },
        { NG , GetUserFriendlyName( NG ) },
        { KP  , GetUserFriendlyName( KP  ) },
        { NO , GetUserFriendlyName( NO ) },
        { OM  , GetUserFriendlyName( OM  ) },
        { PK , GetUserFriendlyName( PK ) },
        { PW  , GetUserFriendlyName( PW  ) },
        { PS , GetUserFriendlyName( PS ) },
        { PA  , GetUserFriendlyName( PA  ) },
        { PG , GetUserFriendlyName( PG ) },
        { PY  , GetUserFriendlyName( PY  ) },
        { PE , GetUserFriendlyName( PE ) },
        { PH  , GetUserFriendlyName( PH  ) },
        { PL , GetUserFriendlyName( PL ) },
        { PT  , GetUserFriendlyName( PT  ) },
        { QA , GetUserFriendlyName( QA ) },
        { RO  , GetUserFriendlyName( RO  ) },
        { RU , GetUserFriendlyName( RU ) },
        { RW  , GetUserFriendlyName( RW  ) },
        { KN , GetUserFriendlyName( KN ) },
        { LC  , GetUserFriendlyName( LC  ) },
        { VC , GetUserFriendlyName( VC ) },
        { WS  , GetUserFriendlyName( WS  ) },
        { SM , GetUserFriendlyName( SM ) },
        { ST  , GetUserFriendlyName( ST  ) },
        { SA , GetUserFriendlyName( SA ) },
        { SN  , GetUserFriendlyName( SN  ) },
        { CS , GetUserFriendlyName( CS ) },
        { SC  , GetUserFriendlyName( SC  ) },
        { SL , GetUserFriendlyName( SL ) },
        { SG  , GetUserFriendlyName( SG  ) },
        { SK , GetUserFriendlyName( SK ) },
        { SI  , GetUserFriendlyName( SI  ) },
        { SB , GetUserFriendlyName( SB ) },
        { SO  , GetUserFriendlyName( SO  ) },
        { ZA , GetUserFriendlyName( ZA ) },
        { KR  , GetUserFriendlyName( KR  ) },
        { SS , GetUserFriendlyName( SS ) },
        { ES  , GetUserFriendlyName( ES  ) },
        { LK , GetUserFriendlyName( LK ) },
        { SD  , GetUserFriendlyName( SD  ) },
        { SR , GetUserFriendlyName( SR ) },
        { SE  , GetUserFriendlyName( SE  ) },
        { CH , GetUserFriendlyName( CH ) },
        { SY  , GetUserFriendlyName( SY  ) },
        { TJ , GetUserFriendlyName( TJ ) },
        { TZ  , GetUserFriendlyName( TZ  ) },
        { TH , GetUserFriendlyName( TH ) },
        { TL  , GetUserFriendlyName( TL  ) },
        { TG , GetUserFriendlyName( TG ) },
        { TO  , GetUserFriendlyName( TO  ) },
        { TT , GetUserFriendlyName( TT ) },
        { TN  , GetUserFriendlyName( TN  ) },
        { TR , GetUserFriendlyName( TR ) },
        { TM  , GetUserFriendlyName( TM  ) },
        { TV , GetUserFriendlyName( TV ) },
        { UG  , GetUserFriendlyName( UG  ) },
        { UA , GetUserFriendlyName( UA ) },
        { AE  , GetUserFriendlyName( AE  ) },
        { GB , GetUserFriendlyName( GB ) },
        { US  , GetUserFriendlyName( US  ) },
        { UY , GetUserFriendlyName( UY ) },
        { UZ  , GetUserFriendlyName( UZ  ) },
        { VU , GetUserFriendlyName( VU ) },
        { VE  , GetUserFriendlyName( VE  ) },
        { VN , GetUserFriendlyName( VN ) },
        { YE  , GetUserFriendlyName( YE  ) },
        { ZM , GetUserFriendlyName( ZM ) },
        { ZW  , GetUserFriendlyName( ZW  ) },
    }.OrderBy(c => c.Value).ToDictionary(c => c.Key, c => c.Value);


    
    public static string GetUserFriendlyName(string value) => value switch
    {
        AF => " Afghanistan ",
        AL  => " Albania ",
        DZ  => " Algeria ",
        AD => " Andorra ",
        AO  => " Angola ",
        AG  => " Antigua and Barbuda ",
        AR  => " Argentina   ",
        AM => " Armenia ",
        AU  => " Australia ",
        AT  => " Austria ",
        AZ => " Azerbaijan  ",
        BS  => " Bahamas ",
        BH  => " Bahrain ",
        BD => " Bangladesh  ",
        BB  => " Barbados ",
        BY  => " Belarus ",
        BE => " Belgium ",
        BZ  => " Belize ",
        BJ  => " Benin   ",
        BT => " Bhutan  ",
        BO  => " Bolivia ",
        BA  => " Bosnia and Herzegovina ",
        BW  => " Botswana    ",
        BR => " Brazil  ",
        BN  => " Brunei ",
        BG  => " Bulgaria    ",
        BF => " Burkina Faso ",
        BI  => " Burundi ",
        CV => " Cabo Verde ",
        KH  => " Cambodia    ",
        CM => " Cameroon    ",
        CA  => " Canada ",
        CF  => " Central African Republic ",
        TD  => " Chad    ",
        CL => " Chile   ",
        CN  => " China ",
        CO  => " Colombia    ",
        KM => " Comoros ",
        CG  => " Congo(Congo - Brazzaville) ",
        CR  => " Costa Rica  ",
        CI  => " Côte d’Ivoire ",
        HR => " Croatia ",
        CU => " Cuba ",
        CY => " Cyprus ",
        CZ => " Czechia(Czech Republic)    ",
        CD  => " Democratic Republic of the Congo    ",
        DK  => " Denmark ",
        DJ  => " Djibouti    ",
        DM  => " Dominica    ",
        DO  => " Dominican Republic ",
        EC => " Ecuador ",
        EG => " Egypt ",
        SV => " El Salvador ",
        GQ  => " Equatorial Guinea ",
        ER => " Eritrea ",
        EE => " Estonia ",
        SZ => " Eswatini(fmr. “Swaziland”) ",
        ET  => " Ethiopia    ",
        FJ  => " Fiji    ",
        FI  => " Finland ",
        FR  => " France  ",
        GA  => " Gabon   ",
        GM  => " Gambia  ",
        GE  => " Georgia ",
        DE  => " Germany ",
        GH  => " Ghana   ",
        GR  => " Greece  ",
        GD  => " Grenada ",
        GT  => " Guatemala   ",
        GN  => " Guinea  ",
        GW  => " Guinea-Bissau ",
        GY => " Guyana ",
        HT => " Haiti ",
        VA => " Holy See    ",
        HN  => " Honduras    ",
        HU  => " Hungary ",
        IS  => " Iceland ",
        IN  => " India   ",
        ID  => " Indonesia   ",
        IR  => " Iran    ",
        IQ  => " Iraq    ",
        IE  => " Ireland ",
        IL  => " Israel  ",
        IT  => " Italy   ",
        JM  => " Jamaica ",
        JP  => " Japan   ",
        JO  => " Jordan  ",
        KZ  => " Kazakhstan  ",
        KE  => " Kenya   ",
        KI  => " Kiribati    ",
        KW  => " Kuwait  ",
        KG  => " Kyrgyzstan  ",
        LA  => " Laos    ",
        LV  => " Latvia  ",
        LB  => " Lebanon ",
        LS  => " Lesotho ",
        LR  => " Liberia ",
        LY  => " Libya   ",
        LI  => " Liechtenstein   ",
        LT  => " Lithuania   ",
        LU  => " Luxembourg  ",
        MK  => " Macedonia   ",
        MG  => " Madagascar  ",
        MW  => " Malawi  ",
        MY  => " Malaysia    ",
        MV  => " Maldives    ",
        ML  => " Mali    ",
        MT  => " Malta   ",
        MH  => " Marshall Islands ",
        MR => " Mauritania ",
        MU => " Mauritius ",
        MX => " Mexico ",
        FM => " Micronesia ",
        MD => " Moldova ",
        MC => " Monaco ",
        MN => " Mongolia ",
        ME => " Montenegro ",
        MA => " Morocco ",
        MZ => " Mozambique ",
        MM => " Myanmar(formerly Burma)    ",
        NA  => " Namibia ",
        NR  => " Nauru   ",
        NP  => " Nepal   ",
        NL  => " Netherlands ",
        NZ  => " New Zealand ",
        NI => " Nicaragua ",
        NE => " Niger ",
        NG => " Nigeria ",
        KP => " North Korea ",
        NO  => " Norway  ",
        OM  => " Oman    ",
        PK  => " Pakistan    ",
        PW  => " Palau   ",
        PS  => " Palestine State ",
        PA => " Panama ",
        PG => " Papua New Guinea ",
        PY => " Paraguay ",
        PE => " Peru ",
        PH => " Philippines ",
        PL => " Poland ",
        PT => " Portugal ",
        QA => " Qatar ",
        RO => " Romania ",
        RU => " Russia ",
        RW => " Rwanda ",
        KN => " Saint Kitts and Nevis   ",
        LC  => " Saint Lucia ",
        VC => " Saint Vincent and the Grenadines ",
        WS => " Samoa ",
        SM => " San Marino  ",
        ST  => " Sao Tome and Principe ",
        SA => " Saudi Arabia    ",
        SN  => " Senegal ",
        CS  => " Serbia  ",
        SC  => " Seychelles  ",
        SL  => " Sierra Leone ",
        SG => " Singapore ",
        SK => " Slovakia ",
        SI => " Slovenia ",
        SB => " Solomon Islands ",
        SO  => " Somalia ",
        ZA  => " South Africa ",
        KR => " South Korea ",
        SS  => " South Sudan ",
        ES => " Spain ",
        LK => " Sri Lanka   ",
        SD  => " Sudan   ",
        SR  => " Suriname    ",
        SE  => " Sweden  ",
        CH  => " Switzerland ",
        SY  => " Syria   ",
        TJ  => " Tajikistan  ",
        TZ  => " Tanzania    ",
        TH  => " Thailand    ",
        TL  => " Timor-Leste ",
        TG => " Togo ",
        TO => " Tonga ",
        TT => " Trinidad and Tobago ",
        TN => " Tunisia ",
        TR => " Turkey ",
        TM => " Turkmenistan ",
        TV => " Tuvalu ",
        UG => " Uganda ",
        UA => " Ukraine ",
        AE => " United Arab Emirates ",
        GB => " United Kingdom  ",
        US  => " United States of America ",
        UY => " Uruguay ",
        UZ => " Uzbekistan ",
        VU => " Vanuatu ",
        VE => " Venezuela ",
        VN => " Vietnam ",
        YE => " Yemen ",
        ZM => " Zambia ",
        ZW => " Zimbabwe ",
        _ => ""
    };
}
