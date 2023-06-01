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
using System.Security.Cryptography;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using static System.Net.Mime.MediaTypeNames;
using System.Collections;
using System.Drawing;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.Arm;
using System.Threading.Tasks;

namespace IPSTemplate.BusinessLibrary.StandardCollections;

public class TELanguages
{
    public const string aa  = " aa  ";
    public const string ab  = " ab  ";
    public const string af  = " af  ";
    public const string ak  = " ak  ";
    public const string als = " als ";
    public const string am  = " am  ";
    public const string an  = " an  ";
    public const string ang = " ang ";
    public const string ar  = " ar  ";
    public const string arc = " arc ";
    public const string arz = " arz ";
    public const string ass	= "	ass	";
    public const string ast = " ast ";
    public const string av  = " av  ";
    public const string awa = " awa ";
    public const string ay  = " ay  ";
    public const string az  = " az  ";
    public const string ba  = " ba  ";
    public const string bar = " bar ";
    public const string bat_smg = " bat_smg ";
    public const string bcl = " bcl ";
    public const string be  = " be  ";
    public const string be_x_old = " be_x_old ";
    public const string bg  = " bg  ";
    public const string bh  = " bh  ";
    public const string bi  = " bi  ";
    public const string bm  = " bm  ";
    public const string bn  = " bn  ";
    public const string bo  = " bo  ";
    public const string bpy = " bpy ";
    public const string br  = " br  ";
    public const string brx = " brx ";
    public const string bs  = " bs  ";
    public const string bug = " bug ";
    public const string bxr = " bxr ";
    public const string ca  = " ca  ";
    public const string cdo = " cdo ";
    public const string ce  = " ce  ";
    public const string ceb = " ceb ";
    public const string ch  = " ch  ";
    public const string cho = " cho ";
    public const string chr = " chr ";
    public const string chy = " chy ";
    public const string ckb = " ckb ";
    public const string co  = " co  ";
    public const string cr  = " cr  ";
    public const string crn = " crn ";
    public const string cs  = " cs  ";
    public const string csb = " csb ";
    public const string cu  = " cu  ";
    public const string cv  = " cv  ";
    public const string cy  = " cy  ";
    public const string da  = " da  ";
    public const string de  = " de  ";
    public const string diq = " diq ";
    public const string dsb = " dsb ";
    public const string dv  = " dv  ";
    public const string dz  = " dz  ";
    public const string ee  = " ee  ";
    public const string el  = " el  ";
    public const string en  = " en  ";
    public const string eo  = " eo  ";
    public const string es  = " es  ";
    public const string et  = " et  ";
    public const string eu  = " eu  ";
    public const string ext = " ext ";
    public const string fa  = " fa  ";
    public const string ff  = " ff  ";
    public const string fi  = " fi  ";
    public const string fiu_vro = " fiu_vro ";
    public const string fj  = " fj  ";
    public const string fo  = " fo  ";
    public const string fr  = " fr  ";
    public const string frp = " frp ";
    public const string fur = " fur ";
    public const string fy  = " fy  ";
    public const string ga  = " ga  ";
    public const string gan = " gan ";
    public const string gbm = " gbm ";
    public const string gd  = " gd  ";
    public const string gil = " gil ";
    public const string gl  = " gl  ";
    public const string gn  = " gn  ";
    public const string got = " got ";
    public const string gu  = " gu  ";
    public const string gv  = " gv  ";
    public const string ha  = " ha  ";
    public const string hak = " hak ";
    public const string haw = " haw ";
    public const string he  = " he  ";
    public const string hi  = " hi  ";
    public const string ho  = " ho  ";
    public const string hr  = " hr  ";
    public const string ht  = " ht  ";
    public const string hu  = " hu  ";
    public const string hy  = " hy  ";
    public const string hz  = " hz  ";
    public const string ia  = " ia  ";
    public const string id  = " id  ";
    public const string ie  = " ie  ";
    public const string ig  = " ig  ";
    public const string ii  = " ii  ";
    public const string ik  = " ik  ";
    public const string ilo = " ilo ";
    public const string inh = " inh ";
    public const string io  = " io  ";
    public const string isl	= "	isl	";
    public const string it  = " it  ";
    public const string iu  = " iu  ";
    public const string ja  = " ja  ";
    public const string jbo = " jbo ";
    public const string jv  = " jv  ";
    public const string ka  = " ka  ";
    public const string kg  = " kg  ";
    public const string ki  = " ki  ";
    public const string kj  = " kj  ";
    public const string kk  = " kk  ";
    public const string kl  = " kl  ";
    public const string km  = " km  ";
    public const string kn  = " kn  ";
    public const string khw = " khw ";
    public const string ko  = " ko  ";
    public const string kr  = " kr  ";
    public const string ks  = " ks  ";
    public const string ksh = " ksh ";
    public const string ku  = " ku  ";
    public const string kv  = " kv  ";
    public const string kw  = " kw  ";
    public const string ky  = " ky  ";
    public const string la  = " la  ";
    public const string lad = " lad ";
    public const string lan = " lan ";
    public const string lb  = " lb  ";
    public const string lg  = " lg  ";
    public const string li  = " li  ";
    public const string lij = " lij ";
    public const string lmo = " lmo ";
    public const string ln  = " ln  ";
    public const string lo  = " lo  ";
    public const string lzz = " lzz ";
    public const string lt  = " lt  ";
    public const string lv  = " lv  ";
    public const string map_bms = " map_bms ";
    public const string mg  = " mg  ";
    public const string man = " man ";
    public const string mh  = " mh  ";
    public const string mi  = " mi  ";
    public const string min = " min ";
    public const string mk  = " mk  ";
    public const string ml  = " ml  ";
    public const string mn  = " mn  ";
    public const string mo  = " mo  ";
    public const string mr  = " mr  ";
    public const string mrh = " mrh ";
    public const string ms  = " ms  ";
    public const string mt  = " mt  ";
    public const string mus = " mus ";
    public const string mwl = " mwl ";
    public const string my  = " my  ";
    public const string na  = " na  ";
    public const string nah = " nah ";
    public const string nap = " nap ";
    public const string nd  = " nd  ";
    public const string nds = " nds ";
    public const string nds_nl = " nds_nl ";
    public const string ne  = " ne  ";
    public const string newa = " newa ";
    public const string ng  = " ng  ";
    public const string nl  = " nl  ";
    public const string nn  = " nn  ";
    public const string no  = " no  ";
    public const string nr  = " nr  ";
    public const string nso = " nso ";
    public const string nrm = " nrm ";
    public const string nv  = " nv  ";
    public const string ny  = " ny  ";
    public const string oc  = " oc  ";
    public const string oj  = " oj  ";
    public const string om  = " om  ";
    public const string or  = " or  ";
    public const string os  = " os  ";
    public const string pa  = " pa  ";
    public const string pag = " pag ";
    public const string pam = " pam ";
    public const string pap = " pap ";
    public const string pdc = " pdc ";
    public const string pi  = " pi  ";
    public const string pih = " pih ";
    public const string pl  = " pl  ";
    public const string pms = " pms ";
    public const string ps  = " ps  ";
    public const string pt  = " pt  ";
    public const string qu  = " qu  ";
    public const string rm  = " rm  ";
    public const string rmy = " rmy ";
    public const string rn  = " rn  ";
    public const string ro  = " ro  ";
    public const string roa_rup = " roa_rup ";
    public const string ru  = " ru  ";
    public const string rw  = " rw  ";
    public const string sa  = " sa  ";
    public const string sc  = " sc  ";
    public const string scn = " scn ";
    public const string sco = " sco ";
    public const string sd  = " sd  ";
    public const string se  = " se  ";
    public const string sg  = " sg  ";
    public const string sh  = " sh  ";
    public const string si  = " si  ";
    public const string simple  = " simple  ";
    public const string sk  = " sk  ";
    public const string sl  = " sl  ";
    public const string sm  = " sm  ";
    public const string sn  = " sn  ";
    public const string so  = " so  ";
    public const string sq  = " sq  ";
    public const string sr  = " sr  ";
    public const string ss  = " ss  ";
    public const string st  = " st  ";
    public const string su  = " su  ";
    public const string sv  = " sv  ";
    public const string sw  = " sw  ";
    public const string ta  = " ta  ";
    public const string te  = " te  ";
    public const string tet = " tet ";
    public const string tg  = " tg  ";
    public const string th  = " th  ";
    public const string ti  = " ti  ";
    public const string tk  = " tk  ";
    public const string tl  = " tl  ";
    public const string tlh = " tlh ";
    public const string tn  = " tn  ";
    public const string to  = " to  ";
    public const string tpi = " tpi ";
    public const string tr  = " tr  ";
    public const string ts  = " ts  ";
    public const string tt  = " tt  ";
    public const string tum = " tum ";
    public const string tw  = " tw  ";
    public const string ty  = " ty  ";
    public const string udm = " udm ";
    public const string ug  = " ug  ";
    public const string uk  = " uk  ";
    public const string ur  = " ur  ";
    public const string uz  = " uz  ";
    public const string uz_AF   = " uz_AF   ";
    public const string ve  = " ve  ";
    public const string vi  = " vi  ";
    public const string vec = " vec ";
    public const string vls = " vls ";
    public const string vo  = " vo  ";
    public const string wa  = " wa  ";
    public const string war = " war ";
    public const string wo  = " wo  ";
    public const string xal = " xal ";
    public const string xh  = " xh  ";
    public const string xmf = " xmf ";
    public const string yi  = " yi  ";
    public const string yo  = " yo  ";
    public const string za  = " za  ";
    public const string zg  = " zg  ";
    public const string zh  = " zh  ";
    public const string zh_classical = " zh_classical ";
    public const string zh_min_nan = " zh_min_nan ";
    public const string zh_yue = " zh_yue ";
    public const string zu  = " zu  ";



    public static List<string> All => new()
    {
        aa   ,
        ab  ,
        af  ,
        ak  ,
        als ,
        am  ,
        an  ,
        ang ,
        ar  ,
        arc ,
        arz ,
        ass ,
        ast ,
        av  ,
        awa ,
        ay  ,
        az  ,
        ba  ,
        bar ,
        bat_smg ,
        bcl ,
        be  ,
        be_x_old    ,
        bg  ,
        bh  ,
        bi  ,
        bm  ,
        bn  ,
        bo  ,
        bpy ,
        br  ,
        brx ,
        bs  ,
        bug ,
        bxr ,
        ca  ,
        cdo ,
        ce  ,
        ceb ,
        ch  ,
        cho ,
        chr ,
        chy ,
        ckb ,
        co  ,
        cr  ,
        crn ,
        cs  ,
        csb ,
        cu  ,
        cv  ,
        cy  ,
        da  ,
        de  ,
        diq ,
        dsb ,
        dv  ,
        dz  ,
        ee  ,
        el  ,
        en  ,
        eo  ,
        es  ,
        et  ,
        eu  ,
        ext ,
        fa  ,
        ff  ,
        fi  ,
        fiu_vro ,
        fj  ,
        fo  ,
        fr  ,
        frp ,
        fur ,
        fy  ,
        ga  ,
        gan ,
        gbm ,
        gd  ,
        gil ,
        gl  ,
        gn  ,
        got ,
        gu  ,
        gv  ,
        ha  ,
        hak ,
        haw ,
        he  ,
        hi  ,
        ho  ,
        hr  ,
        ht  ,
        hu  ,
        hy  ,
        hz  ,
        ia  ,
        id  ,
        ie  ,
        ig  ,
        ii  ,
        ik  ,
        ilo ,
        inh ,
        io  ,
        isl ,
        it  ,
        iu  ,
        ja  ,
        jbo ,
        jv  ,
        ka  ,
        kg  ,
        ki  ,
        kj  ,
        kk  ,
        kl  ,
        km  ,
        kn  ,
        khw ,
        ko  ,
        kr  ,
        ks  ,
        ksh ,
        ku  ,
        kv  ,
        kw  ,
        ky  ,
        la  ,
        lad ,
        lan ,
        lb  ,
        lg  ,
        li  ,
        lij ,
        lmo ,
        ln  ,
        lo  ,
        lzz ,
        lt  ,
        lv  ,
        map_bms ,
        mg  ,
        man ,
        mh  ,
        mi  ,
        min ,
        mk  ,
        ml  ,
        mn  ,
        mo  ,
        mr  ,
        mrh ,
        ms  ,
        mt  ,
        mus ,
        mwl ,
        my  ,
        na  ,
        nah ,
        nap ,
        nd  ,
        nds ,
        nds_nl  ,
        ne  ,
        newa    ,
        ng  ,
        nl  ,
        nn  ,
        no  ,
        nr  ,
        nso ,
        nrm ,
        nv  ,
        ny  ,
        oc  ,
        oj  ,
        om  ,
        or  ,
        os  ,
        pa  ,
        pag ,
        pam ,
        pap ,
        pdc ,
        pi  ,
        pih ,
        pl  ,
        pms ,
        ps  ,
        pt  ,
        qu  ,
        rm  ,
        rmy ,
        rn  ,
        ro  ,
        roa_rup ,
        ru  ,
        rw  ,
        sa  ,
        sc  ,
        scn ,
        sco ,
        sd  ,
        se  ,
        sg  ,
        sh  ,
        si  ,
        simple  ,
        sk  ,
        sl  ,
        sm  ,
        sn  ,
        so  ,
        sq  ,
        sr  ,
        ss  ,
        st  ,
        su  ,
        sv  ,
        sw  ,
        ta  ,
        te  ,
        tet ,
        tg  ,
        th  ,
        ti  ,
        tk  ,
        tl  ,
        tlh ,
        tn  ,
        to  ,
        tpi ,
        tr  ,
        ts  ,
        tt  ,
        tum ,
        tw  ,
        ty  ,
        udm ,
        ug  ,
        uk  ,
        ur  ,
        uz  ,
        uz_AF   ,
        ve  ,
        vi  ,
        vec ,
        vls ,
        vo  ,
        wa  ,
        war ,
        wo  ,
        xal ,
        xh  ,
        xmf ,
        yi  ,
        yo  ,
        za  ,
        zg  ,
        zh  ,
        zh_classical    ,
        zh_min_nan  ,
        zh_yue  ,
        zu  ,
    };

    public static Dictionary<string, string> OrderedUserFriendlyNameMap => new Dictionary<string, string>
    {
        { aa  , GetUserFriendlyName( aa  ) },
        { ab  , GetUserFriendlyName( ab  ) },
        { af  , GetUserFriendlyName( af  ) },
        { ak  , GetUserFriendlyName( ak  ) },
        { als , GetUserFriendlyName( als ) },
        { am  , GetUserFriendlyName( am  ) },
        { an  , GetUserFriendlyName( an  ) },
        { ang , GetUserFriendlyName( ang ) },
        { ar  , GetUserFriendlyName( ar  ) },
        { arc , GetUserFriendlyName( arc ) },
        { arz , GetUserFriendlyName( arz ) },
        { ass , GetUserFriendlyName( ass ) },
        { ast , GetUserFriendlyName( ast ) },
        { av  , GetUserFriendlyName( av  ) },
        { awa , GetUserFriendlyName( awa ) },
        { ay  , GetUserFriendlyName( ay  ) },
        { az  , GetUserFriendlyName( az  ) },
        { ba  , GetUserFriendlyName( ba  ) },
        { bar , GetUserFriendlyName( bar ) },
        { bat_smg , GetUserFriendlyName( bat_smg ) },
        { bcl , GetUserFriendlyName( bcl ) },
        { be  , GetUserFriendlyName( be  ) },
        { be_x_old    , GetUserFriendlyName( be_x_old    ) },
        { bg  , GetUserFriendlyName( bg  ) },
        { bh  , GetUserFriendlyName( bh  ) },
        { bi  , GetUserFriendlyName( bi  ) },
        { bm  , GetUserFriendlyName( bm  ) },
        { bn  , GetUserFriendlyName( bn  ) },
        { bo  , GetUserFriendlyName( bo  ) },
        { bpy , GetUserFriendlyName( bpy ) },
        { br  , GetUserFriendlyName( br  ) },
        { brx , GetUserFriendlyName( brx ) },
        { bs  , GetUserFriendlyName( bs  ) },
        { bug , GetUserFriendlyName( bug ) },
        { bxr , GetUserFriendlyName( bxr ) },
        { ca  , GetUserFriendlyName( ca  ) },
        { cdo , GetUserFriendlyName( cdo ) },
        { ce  , GetUserFriendlyName( ce  ) },
        { ceb , GetUserFriendlyName( ceb ) },
        { ch  , GetUserFriendlyName( ch  ) },
        { cho , GetUserFriendlyName( cho ) },
        { chr , GetUserFriendlyName( chr ) },
        { chy , GetUserFriendlyName( chy ) },
        { ckb , GetUserFriendlyName( ckb ) },
        { co  , GetUserFriendlyName( co  ) },
        { cr  , GetUserFriendlyName( cr  ) },
        { crn , GetUserFriendlyName( crn ) },
        { cs  , GetUserFriendlyName( cs  ) },
        { csb , GetUserFriendlyName( csb ) },
        { cu  , GetUserFriendlyName( cu  ) },
        { cv  , GetUserFriendlyName( cv  ) },
        { cy  , GetUserFriendlyName( cy  ) },
        { da  , GetUserFriendlyName( da  ) },
        { de  , GetUserFriendlyName( de  ) },
        { diq , GetUserFriendlyName( diq ) },
        { dsb , GetUserFriendlyName( dsb ) },
        { dv  , GetUserFriendlyName( dv  ) },
        { dz  , GetUserFriendlyName( dz  ) },
        { ee  , GetUserFriendlyName( ee  ) },
        { el  , GetUserFriendlyName( el  ) },
        { en  , GetUserFriendlyName( en  ) },
        { eo  , GetUserFriendlyName( eo  ) },
        { es  , GetUserFriendlyName( es  ) },
        { et  , GetUserFriendlyName( et  ) },
        { eu  , GetUserFriendlyName( eu  ) },
        { ext , GetUserFriendlyName( ext ) },
        { fa  , GetUserFriendlyName( fa  ) },
        { ff  , GetUserFriendlyName( ff  ) },
        { fi  , GetUserFriendlyName( fi  ) },
        { fiu_vro , GetUserFriendlyName( fiu_vro ) },
        { fj  , GetUserFriendlyName( fj  ) },
        { fo  , GetUserFriendlyName( fo  ) },
        { fr  , GetUserFriendlyName( fr  ) },
        { frp , GetUserFriendlyName( frp ) },
        { fur , GetUserFriendlyName( fur ) },
        { fy  , GetUserFriendlyName( fy  ) },
        { ga  , GetUserFriendlyName( ga  ) },
        { gan , GetUserFriendlyName( gan ) },
        { gbm , GetUserFriendlyName( gbm ) },
        { gd  , GetUserFriendlyName( gd  ) },
        { gil , GetUserFriendlyName( gil ) },
        { gl  , GetUserFriendlyName( gl  ) },
        { gn  , GetUserFriendlyName( gn  ) },
        { got , GetUserFriendlyName( got ) },
        { gu  , GetUserFriendlyName( gu  ) },
        { gv  , GetUserFriendlyName( gv  ) },
        { ha  , GetUserFriendlyName( ha  ) },
        { hak , GetUserFriendlyName( hak ) },
        { haw , GetUserFriendlyName( haw ) },
        { he  , GetUserFriendlyName( he  ) },
        { hi  , GetUserFriendlyName( hi  ) },
        { ho  , GetUserFriendlyName( ho  ) },
        { hr  , GetUserFriendlyName( hr  ) },
        { ht  , GetUserFriendlyName( ht  ) },
        { hu  , GetUserFriendlyName( hu  ) },
        { hy  , GetUserFriendlyName( hy  ) },
        { hz  , GetUserFriendlyName( hz  ) },
        { ia  , GetUserFriendlyName( ia  ) },
        { id  , GetUserFriendlyName( id  ) },
        { ie  , GetUserFriendlyName( ie  ) },
        { ig  , GetUserFriendlyName( ig  ) },
        { ii  , GetUserFriendlyName( ii  ) },
        { ik  , GetUserFriendlyName( ik  ) },
        { ilo , GetUserFriendlyName( ilo ) },
        { inh , GetUserFriendlyName( inh ) },
        { io  , GetUserFriendlyName( io  ) },
        { isl , GetUserFriendlyName( isl ) },
        { it  , GetUserFriendlyName( it  ) },
        { iu  , GetUserFriendlyName( iu  ) },
        { ja  , GetUserFriendlyName( ja  ) },
        { jbo , GetUserFriendlyName( jbo ) },
        { jv  , GetUserFriendlyName( jv  ) },
        { ka  , GetUserFriendlyName( ka  ) },
        { kg  , GetUserFriendlyName( kg  ) },
        { ki  , GetUserFriendlyName( ki  ) },
        { kj  , GetUserFriendlyName( kj  ) },
        { kk  , GetUserFriendlyName( kk  ) },
        { kl  , GetUserFriendlyName( kl  ) },
        { km  , GetUserFriendlyName( km  ) },
        { kn  , GetUserFriendlyName( kn  ) },
        { khw , GetUserFriendlyName( khw ) },
        { ko  , GetUserFriendlyName( ko  ) },
        { kr  , GetUserFriendlyName( kr  ) },
        { ks  , GetUserFriendlyName( ks  ) },
        { ksh , GetUserFriendlyName( ksh ) },
        { ku  , GetUserFriendlyName( ku  ) },
        { kv  , GetUserFriendlyName( kv  ) },
        { kw  , GetUserFriendlyName( kw  ) },
        { ky  , GetUserFriendlyName( ky  ) },
        { la  , GetUserFriendlyName( la  ) },
        { lad , GetUserFriendlyName( lad ) },
        { lan , GetUserFriendlyName( lan ) },
        { lb  , GetUserFriendlyName( lb  ) },
        { lg  , GetUserFriendlyName( lg  ) },
        { li  , GetUserFriendlyName( li  ) },
        { lij , GetUserFriendlyName( lij ) },
        { lmo , GetUserFriendlyName( lmo ) },
        { ln  , GetUserFriendlyName( ln  ) },
        { lo  , GetUserFriendlyName( lo  ) },
        { lzz , GetUserFriendlyName( lzz ) },
        { lt  , GetUserFriendlyName( lt  ) },
        { lv  , GetUserFriendlyName( lv  ) },
        { map_bms , GetUserFriendlyName( map_bms ) },
        { mg  , GetUserFriendlyName( mg  ) },
        { man , GetUserFriendlyName( man ) },
        { mh  , GetUserFriendlyName( mh  ) },
        { mi  , GetUserFriendlyName( mi  ) },
        { min , GetUserFriendlyName( min ) },
        { mk  , GetUserFriendlyName( mk  ) },
        { ml  , GetUserFriendlyName( ml  ) },
        { mn  , GetUserFriendlyName( mn  ) },
        { mo  , GetUserFriendlyName( mo  ) },
        { mr  , GetUserFriendlyName( mr  ) },
        { mrh , GetUserFriendlyName( mrh ) },
        { ms  , GetUserFriendlyName( ms  ) },
        { mt  , GetUserFriendlyName( mt  ) },
        { mus , GetUserFriendlyName( mus ) },
        { mwl , GetUserFriendlyName( mwl ) },
        { my  , GetUserFriendlyName( my  ) },
        { na  , GetUserFriendlyName( na  ) },
        { nah , GetUserFriendlyName( nah ) },
        { nap , GetUserFriendlyName( nap ) },
        { nd  , GetUserFriendlyName( nd  ) },
        { nds , GetUserFriendlyName( nds ) },
        { nds_nl  , GetUserFriendlyName( nds_nl  ) },
        { ne  , GetUserFriendlyName( ne  ) },
        { newa    , GetUserFriendlyName( newa    ) },
        { ng  , GetUserFriendlyName( ng  ) },
        { nl  , GetUserFriendlyName( nl  ) },
        { nn  , GetUserFriendlyName( nn  ) },
        { no  , GetUserFriendlyName( no  ) },
        { nr  , GetUserFriendlyName( nr  ) },
        { nso , GetUserFriendlyName( nso ) },
        { nrm , GetUserFriendlyName( nrm ) },
        { nv  , GetUserFriendlyName( nv  ) },
        { ny  , GetUserFriendlyName( ny  ) },
        { oc  , GetUserFriendlyName( oc  ) },
        { oj  , GetUserFriendlyName( oj  ) },
        { om  , GetUserFriendlyName( om  ) },
        { or  , GetUserFriendlyName( or  ) },
        { os  , GetUserFriendlyName( os  ) },
        { pa  , GetUserFriendlyName( pa  ) },
        { pag , GetUserFriendlyName( pag ) },
        { pam , GetUserFriendlyName( pam ) },
        { pap , GetUserFriendlyName( pap ) },
        { pdc , GetUserFriendlyName( pdc ) },
        { pi  , GetUserFriendlyName( pi  ) },
        { pih , GetUserFriendlyName( pih ) },
        { pl  , GetUserFriendlyName( pl  ) },
        { pms , GetUserFriendlyName( pms ) },
        { ps  , GetUserFriendlyName( ps  ) },
        { pt  , GetUserFriendlyName( pt  ) },
        { qu  , GetUserFriendlyName( qu  ) },
        { rm  , GetUserFriendlyName( rm  ) },
        { rmy , GetUserFriendlyName( rmy ) },
        { rn  , GetUserFriendlyName( rn  ) },
        { ro  , GetUserFriendlyName( ro  ) },
        { roa_rup , GetUserFriendlyName( roa_rup ) },
        { ru  , GetUserFriendlyName( ru  ) },
        { rw  , GetUserFriendlyName( rw  ) },
        { sa  , GetUserFriendlyName( sa  ) },
        { sc  , GetUserFriendlyName( sc  ) },
        { scn , GetUserFriendlyName( scn ) },
        { sco , GetUserFriendlyName( sco ) },
        { sd  , GetUserFriendlyName( sd  ) },
        { se  , GetUserFriendlyName( se  ) },
        { sg  , GetUserFriendlyName( sg  ) },
        { sh  , GetUserFriendlyName( sh  ) },
        { si  , GetUserFriendlyName( si  ) },
        { simple  , GetUserFriendlyName( simple  ) },
        { sk  , GetUserFriendlyName( sk  ) },
        { sl  , GetUserFriendlyName( sl  ) },
        { sm  , GetUserFriendlyName( sm  ) },
        { sn  , GetUserFriendlyName( sn  ) },
        { so  , GetUserFriendlyName( so  ) },
        { sq  , GetUserFriendlyName( sq  ) },
        { sr  , GetUserFriendlyName( sr  ) },
        { ss  , GetUserFriendlyName( ss  ) },
        { st  , GetUserFriendlyName( st  ) },
        { su  , GetUserFriendlyName( su  ) },
        { sv  , GetUserFriendlyName( sv  ) },
        { sw  , GetUserFriendlyName( sw  ) },
        { ta  , GetUserFriendlyName( ta  ) },
        { te  , GetUserFriendlyName( te  ) },
        { tet , GetUserFriendlyName( tet ) },
        { tg  , GetUserFriendlyName( tg  ) },
        { th  , GetUserFriendlyName( th  ) },
        { ti  , GetUserFriendlyName( ti  ) },
        { tk  , GetUserFriendlyName( tk  ) },
        { tl  , GetUserFriendlyName( tl  ) },
        { tlh , GetUserFriendlyName( tlh ) },
        { tn  , GetUserFriendlyName( tn  ) },
        { to  , GetUserFriendlyName( to  ) },
        { tpi , GetUserFriendlyName( tpi ) },
        { tr  , GetUserFriendlyName( tr  ) },
        { ts  , GetUserFriendlyName( ts  ) },
        { tt  , GetUserFriendlyName( tt  ) },
        { tum , GetUserFriendlyName( tum ) },
        { tw  , GetUserFriendlyName( tw  ) },
        { ty  , GetUserFriendlyName( ty  ) },
        { udm , GetUserFriendlyName( udm ) },
        { ug  , GetUserFriendlyName( ug  ) },
        { uk  , GetUserFriendlyName( uk  ) },
        { ur  , GetUserFriendlyName( ur  ) },
        { uz  , GetUserFriendlyName( uz  ) },
        { uz_AF   , GetUserFriendlyName( uz_AF   ) },
        { ve  , GetUserFriendlyName( ve  ) },
        { vi  , GetUserFriendlyName( vi  ) },
        { vec , GetUserFriendlyName( vec ) },
        { vls , GetUserFriendlyName( vls ) },
        { vo  , GetUserFriendlyName( vo  ) },
        { wa  , GetUserFriendlyName( wa  ) },
        { war , GetUserFriendlyName( war ) },
        { wo  , GetUserFriendlyName( wo  ) },
        { xal , GetUserFriendlyName( xal ) },
        { xh  , GetUserFriendlyName( xh  ) },
        { xmf , GetUserFriendlyName( xmf ) },
        { yi  , GetUserFriendlyName( yi  ) },
        { yo  , GetUserFriendlyName( yo  ) },
        { za  , GetUserFriendlyName( za  ) },
        { zg  , GetUserFriendlyName( zg  ) },
        { zh  , GetUserFriendlyName( zh  ) },
        { zh_classical    , GetUserFriendlyName( zh_classical    ) },
        { zh_min_nan  , GetUserFriendlyName( zh_min_nan  ) },
        { zh_yue  , GetUserFriendlyName( zh_yue  ) },
        { zu  , GetUserFriendlyName( zu  ) },
    }.OrderBy(c => c.Value).ToDictionary(c => c.Key, c => c.Value);


    
    public static string GetUserFriendlyName(string value) => value switch
    {
        aa => " Afar    ",
        ab  => " Abkhazian ",
        af  => " Afrikaans   ",
        ak => " Akan    ",
        als => " Alemannic ",
        am  => " Amharic ",
        an => " Aragonese   ",
        ang => " Angal ",
        ar  => " Arabic  ",
        arc => " Aramaic ",
        arz => " Egyptian Arabic ",
        ass => " Assamese    ",
        ast => " Asturian ",
        av  => " Avar    ",
        awa => " Awadhi  ",
        ay  => " Aymara ",
        az  => " Azerbaijani ",
        ba => " Bashkir ",
        bar => " Bavarian ",
        bat_smg => " Samogitian  ",
        bcl => " Bikol   ",
        be  => " Belarusian ",
        be_x_old    => " Belarusian (Taraškievica)",
        bg => " Bulgarian   ",
        bh  => " Bihari ",
        bi  => " Bislama ",
        bm => " Bambara ",
        bn  => " Bengali ",
        bo  => " Tibetan ",
        bpy => " Bishnupriya Manipuri ",
        br  => " Breton  ",
        brx => " Boro    ",
        bs  => " Bosnian ",
        bug => " Buginese    ",
        bxr => " Buriat(Russia) ",
        ca  => " Catalan ",
        cdo => " Min Dong Chinese ",
        ce  => " Chechen ",
        ceb => " Cebuano ",
        ch  => " Chamorro ",
        cho => " Choctaw ",
        chr => " Cherokee    ",
        chy => " Cheyenne ",
        ckb => " Kurdish (Sorani)",
        co => " Corsican    ",
        cr  => " Cree ",
        crn => " Montenegrin ",
        cs => " Czech   ",
        csb => " Kashubian ",
        cu  => " Old Church Slavonic / Old Bulgarian ",
        cv  => " Chuvash ",
        cy  => " Welsh   ",
        da => " Danish  ",
        de  => " German ",
        diq => " Dimli   ",
        dsb => " Lower Sorbian ",
        dv  => " Divehi  ",
        dz => " Dzongkha    ",
        ee  => " Ewe ",
        el  => " Greek   ",
        en => " English ",
        eo  => " Esperanto ",
        es  => " Spanish ",
        et => " Estonian    ",
        eu  => " Basque ",
        ext => " Extremaduran    ",
        fa => " Persian ",
        ff  => " Peul ",
        fi  => " Finnish ",
        fiu_vro => " Võro ",
        fj  => " Fijian  ",
        fo => " Faroese ",
        fr  => " French ",
        frp => " Arpitan / Franco _ Provençal  ",
        fur => " Friulian ",
        fy  => " West Frisian    ",
        ga  => " Irish ",
        gan => " Gan Chinese ",
        gbm => " Garhwali ",
        gd  => " Scottish Gaelic ",
        gil => " Gilbertese ",
        gl  => " Galician    ",
        gn => " Guarani ",
        got => " Gothic ",
        gu  => " Gujarati    ",
        gv => " Manx    ",
        ha  => " Hausa ",
        hak => " Hakka Chinese   ",
        haw => " Hawaiian ",
        he  => " Hebrew  ",
        hi => " Hindi   ",
        ho  => " Hiri Motu   ",
        hr => " Croatian    ",
        ht  => " Haitian ",
        hu  => " Hungarian   ",
        hy => " Armenian    ",
        hz  => " Herero ",
        ia  => " Interlingua ",
        id => " Indonesian  ",
        ie  => " Interlingue ",
        ig  => " Igbo    ",
        ii => " Sichuan Yi ",
        ik  => " Inupiak ",
        ilo => " Ilokano ",
        inh => " Ingush ",
        io  => " Ido ",
        isl => " Icelandic   ",
        it  => " Italian ",
        iu  => " Inuktitut   ",
        ja => " Japanese    ",
        jbo => " Lojban ",
        jv  => " Javanese    ",
        ka => " Georgian    ",
        kg  => " Kongo ",
        ki  => " Kikuyu  ",
        kj => " Kuanyama    ",
        kk  => " Kazakh ",
        kl  => " Greenlandic ",
        km => " Cambodian   ",
        kn  => " Kannada ",
        khw => " Khowar  ",
        ko => " Korean  ",
        kr  => " Kanuri ",
        ks  => " Kashmiri    ",
        ksh => " Ripuarian   ",
        ku  => " Kurdish(Kurmanji) ",
        kv  => " Komi    ",
        kw => " Cornish ",
        ky  => " Kirghiz ",
        la  => " Latin   ",
        lad => " Ladino / Judeo _ Spanish  ",
        lan => " Lango ",
        lb  => " Luxembourgish   ",
        lg => " Ganda   ",
        li  => " Limburgian ",
        lij => " Ligurian    ",
        lmo => " Lombard ",
        ln  => " Lingala ",
        lo  => " Laotian ",
        lzz => " Laz ",
        lt  => " Lithuanian ",
        lv  => " Latvian ",
        map_bms => " Banyumasan ",
        mg  => " Malagasy    ",
        man => " Mandarin    ",
        mh  => " Marshallese ",
        mi  => " Māori   ",
        min => " Minangkabau ",
        mk  => " Macedonian ",
        ml  => " Malayalam   ",
        mn => " Mongolian   ",
        mo  => " Moldovan ",
        mr  => " Marathi ",
        mrh => " Mara    ",
        ms  => " Malay ",
        mt  => " Maltese ",
        mus => " Creek / Muskogee    ",
        mwl => " Mirandese ",
        my  => " Burmese ",
        na => " Nauruan ",
        nah => " Nahuatl ",
        nap => " Neapolitan  ",
        nd => " North Ndebele ",
        nds => " Low German / Low Saxon ",
        nds_nl  => " Dutch Low Saxon ",
        ne  => " Nepali  ",
        newa => " Newar   ",
        ng  => " Ndonga ",
        nl  => " Dutch   ",
        nn => " Norwegian Nynorsk ",
        no  => " Norwegian   ",
        nr => " South Ndebele ",
        nso => " Northern Sotho  ",
        nrm => " Norman ",
        nv  => " Navajo  ",
        ny => " Chichewa    ",
        oc  => " Occitan ",
        oj  => " Ojibwa  ",
        om => " Oromo   ",
        or => " Oriya   ",
        os => " Ossetian / Ossetic  ",
        pa  => " Panjabi / Punjabi   ",
        pag => " Pangasinan  ",
        pam => " Kapampangan ",
        pap => " Papiamentu  ",
        pdc => " Pennsylvania German ",
        pi  => " Pali    ",
        pih => " Norfolk ",
        pl  => " Polish ",
        pms => " Piedmontese ",
        ps => " Pashto  ",
        pt  => " Portuguese ",
        qu  => " Quechua ",
        rm => " Raeto Romance ",
        rmy => " Romani  ",
        rn => " Kirundi ",
        ro  => " Romanian ",
        roa_rup => " Aromanian   ",
        ru => " Russian ",
        rw  => " Rwandi ",
        sa  => " Sanskrit    ",
        sc => " Sardinian   ",
        scn => " Sicilian ",
        sco => " Scots   ",
        sd => " Sindhi  ",
        se  => " Northern Sami   ",
        sg => " Sango   ",
        sh  => " Serbo _ Croatian  ",
        si => " Sinhalese   ",
        simple  => " Simple English  ",
        sk => " Slovak  ",
        sl  => " Slovenian ",
        sm  => " Samoan  ",
        sn => " Shona   ",
        so  => " Somalia ",
        sq  => " Albanian    ",
        sr => " Serbian ",
        ss  => " Swati ",
        st  => " Southern Sotho  ",
        su  => " Sundanese ",
        sv  => " Swedish ",
        sw => " Swahili ",
        ta  => " Tamil ",
        te  => " Telugu  ",
        tet => " Tetum   ",
        tg  => " Tajik ",
        th  => " Thai    ",
        ti => " Tigrinya    ",
        tk  => " Turkmen ",
        tl  => " Tagalog ",
        tlh => " Klingon ",
        tn  => " Tswana ",
        to  => " Tonga   ",
        tpi => " Tok Pisin ",
        tr  => " Turkish ",
        ts => " Tsonga  ",
        tt  => " Tatar ",
        tum => " Tumbuka ",
        tw => " Twi ",
        ty  => " Tahitian ",
        udm => " Udmurt  ",
        ug => " Uyghur  ",
        uk  => " Ukrainian ",
        ur  => " Urdu    ",
        uz => " Uzbek   ",
        uz_AF   => " Uzbeki Afghanistan  ",
        ve => " Venda   ",
        vi  => " Vietnamese ",
        vec => " Venetian    ",
        vls => " West Flemish ",
        vo  => " Volapük ",
        wa => " Walloon ",
        war => " Waray / Samar _ Leyte Visayan ",
        wo  => " Wolof ",
        xal => " Kalmyk  ",
        xh => " Xhosa   ",
        xmf => " Megrelian ",
        yi  => " Yiddish ",
        yo => " Yoruba  ",
        za  => " Zhuang ",
        zg  => " Moroccan Amazigh    ",
        zh  => " Chinese ",
        zh_classical    => " Classical Chinese   ",
        zh_min_nan  => " Minnan  ",
        zh_yue  => " Cantonese ",
        zu  => " Zulu    ",
        _ => ""
    };
}
