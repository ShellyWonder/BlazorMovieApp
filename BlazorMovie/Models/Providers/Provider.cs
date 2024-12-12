using System.Text.Json.Serialization;

namespace BlazorMovie.Models.Providers
{
    public class Provider
    {

        [JsonPropertyName("id")]
        public int id { get; set; }

        [JsonPropertyName("results")]
        public Dictionary<string, ProviderDetail> ProviderResults { get; set; } = new();
    }

    public class AD : ProviderDetail<Flatrate, ProviderOption, ProviderOption>{ }
    public class Flatrate : ProviderOption { }
    public class AE : ProviderDetail<ProviderOption, Buy, Rent> { }
    public class Rent : ProviderOption { }
    public class Buy : ProviderOption { }
    public class AL : ProviderDetail<Flatrate1, ProviderOption, ProviderOption> { }
    public class Flatrate1 : ProviderOption { }
    public class AR : ProviderDetail<Flatrate2, Buy1, ProviderOption> { }
    public class Flatrate2 : ProviderOption { }
    public class Buy1 : ProviderOption { }
    public class AT : ProviderDetail { }
    public class Buy2 : ProviderOption { }
    public class Flatrate3 : ProviderOption { }
    public class Rent1 : ProviderOption { }
    public class AU : ProviderDetail<Flatrate4, Buy3, ProviderOption> { }
    public class Flatrate4 : ProviderOption { }
    public class Buy3 : ProviderOption { }
    public class BA : ProviderDetail<Flatrate5, ProviderOption, ProviderOption> { }
    public class Flatrate5 : ProviderOption { }
    public class BE : ProviderDetail { }
    public class Buy4 : ProviderOption { }
    public class Flatrate6 : ProviderOption { }
    public class Rent2 : ProviderOption { }
    public class BG : ProviderDetail { }
    public class Flatrate7 : ProviderOption { }
    public class Rent3 : ProviderOption { }
    public class Buy5 : ProviderOption { }
    public class BO : ProviderDetail<Flatrate8, ProviderOption, ProviderOption> { }
    public class Flatrate8 : ProviderOption { }
    public class BR : ProviderDetail<Flatrate9, ProviderOption, ProviderOption> { }
    public class Flatrate9 : ProviderOption { }
    public class BZ : ProviderDetail<Flatrate10, ProviderOption, ProviderOption> { }
    public class Flatrate10 : ProviderOption { }
    public class CA : ProviderDetail { }
    public class Flatrate11 : ProviderOption { }
    public class Buy6 : ProviderOption { }
    public class Rent4 : ProviderOption { }
    public class CH : ProviderDetail { }
    public class Buy7 : ProviderOption { }
    public class Rent5 : ProviderOption { }
    public class Flatrate12 : ProviderOption { }
    public class CL : ProviderDetail<Flatrate13, Buy8, ProviderOption> { }
    public class Buy8 : ProviderOption { }
    public class Flatrate13 : ProviderOption { }
    public class CO : ProviderDetail<Flatrate14, Buy9, ProviderOption> { }
    public class Flatrate14 : ProviderOption { }
    public class Buy9 : ProviderOption { }
    public class CR : ProviderDetail<Flatrate15, ProviderOption, ProviderOption> { }
    public class Flatrate15 : ProviderOption { }
    public class CY : ProviderDetail<ProviderOption, Buy10, ProviderOption> { }
    public class Buy10 : ProviderOption { }
    public class CZ : ProviderDetail { }
    public class Rent6 : ProviderOption { }
    public class Buy11 : ProviderOption { }
    public class Flatrate16 : ProviderOption { }
    public class DE : ProviderDetail { }
    public class Rent7 : ProviderOption { }
    public class Flatrate17 : ProviderOption { }
    public class Buy12 : ProviderOption { }
    public class DK : ProviderDetail { }
    public class Rent8 : ProviderOption { }
    public class Buy13 : ProviderOption { }
    public class Flatrate18 : ProviderOption { }
    public class DO : ProviderDetail<Flatrate19, ProviderOption, ProviderOption> { }
    public class Flatrate19 : ProviderOption { }
    public class EC :ProviderDetail<Flatrate20, Buy14, ProviderOption> { } 
    public class Buy14 : ProviderOption { }
    public class Flatrate20 : ProviderOption { }
    public class EE : ProviderDetail { }
    public class Flatrate21 : ProviderOption { }
    public class Buy15 : ProviderOption { }
    public class Rent9 : ProviderOption { }
    public class EG : ProviderDetail { }
    public class Rent10 : ProviderOption { }
    public class Buy16 : ProviderOption { }
    public class Flatrate22 : ProviderOption { }
    public class ES : ProviderDetail { }
    public class Rent11 : ProviderOption { }
    public class Buy17 : ProviderOption { }
    public class Flatrate23 : ProviderOption { }
    public class FI : ProviderDetail { }
    public class Flatrate24 : ProviderOption { }
    public class Rent12 : ProviderOption { }
    public class Buy18 : ProviderOption { }
    public class FR : ProviderDetail { }
    public class Rent13 : ProviderOption { }
    public class Buy19 : ProviderOption { }
    public class Flatrate25 : ProviderOption { }
    public class GB  : ProviderDetail { }
    public class Buy20 : ProviderOption { }
    public class Flatrate26 : ProviderOption { }
    public class Rent14 : ProviderOption { }
    public class GR : ProviderDetail<Flatrate27, Buy21, ProviderOption> { } 
    public class Buy21 : ProviderOption { }
    public class Flatrate27 : ProviderOption { }
    public class GT : ProviderDetail<Flatrate28, ProviderOption, ProviderOption> { } 
    public class Flatrate28 : ProviderOption { }
    public class HK : ProviderDetail { }
    public class Buy22 : ProviderOption { }
    public class Rent15 : ProviderOption { }
    public class Flatrate29 : ProviderOption { }
    public class HN : ProviderDetail<Flatrate30, ProviderOption, ProviderOption> { } 
   public class Flatrate30 : ProviderOption { }
    public class HR : ProviderDetail<Flatrate31, ProviderOption, ProviderOption> { } 
    public class Flatrate31 : ProviderOption { }
    public class HU : ProviderDetail { }
    public class Flatrate32 : ProviderOption { }
    public class Buy23 : ProviderOption { }
    public class Rent16 : ProviderOption { }
    public class ID : ProviderDetail<Flatrate33, ProviderOption, ProviderOption> { }
    public class Flatrate33 : ProviderOption { }
    public class IE : ProviderDetail { }
    public class Flatrate34 : ProviderOption { }
    public class Buy24 : ProviderOption { }
    public class Rent17 : ProviderOption { }
    public class IL : ProviderDetail<ProviderOption, Buy25, ProviderOption> { } 
    public class Buy25 : ProviderOption { }
    public class IN : ProviderDetail { }
    public class Flatrate35 : ProviderOption { }
    public class Rent18 : ProviderOption { }
    public class Buy26 : ProviderOption { }
    public class IS : ProviderDetail { }
    public class Rent19 : ProviderOption { }
    public class Flatrate36 : ProviderOption { }
    public class Buy27 : ProviderOption { }
    public class IT : ProviderDetail { }
    public class Rent20 : ProviderOption { }
    public class Flatrate37 : ProviderOption { }
    public class Buy28 : ProviderOption { }
    public class JM : ProviderDetail<Flatrate38, ProviderOption, ProviderOption> { }
    public class Flatrate38 : ProviderOption { }
    public class JP : ProviderDetail { }
    public class Buy29 : ProviderOption { }
    public class Rent21 : ProviderOption { }
    public class Flatrate39 : ProviderOption { }
    public class KR : ProviderDetail<Flatrate33, Buy30, ProviderOption> { }
    public class Buy30 : ProviderOption { }
    public class Flatrate40 : ProviderOption { }
    public class LC : ProviderDetail<Flatrate41, ProviderOption, ProviderOption> { }
    public class Flatrate41 : ProviderOption { }
    public class LI : ProviderDetail<Flatrate42, ProviderOption, ProviderOption> { }
    public class Flatrate42 : ProviderOption { }
    public class LT : ProviderDetail { }
    public class Buy31 : ProviderOption { }
    public class Rent22 : ProviderOption { }
    public class Flatrate43 : ProviderOption { }
    public class LU : ProviderDetail { }
    public class Flatrate44 : ProviderOption { }
    public class Buy32 : ProviderOption { }
    public class Rent23 : ProviderOption { }
    public class LV : ProviderDetail { }
    public class Rent24 : ProviderOption { }
    public class Flatrate45 : ProviderOption { }
    public class Buy33 : ProviderOption { }
    public class ME : ProviderDetail<Flatrate46, ProviderOption, ProviderOption> { }
    public class Flatrate46 : ProviderOption { }
    public class MK : ProviderDetail<Flatrate47, ProviderOption, ProviderOption> { }
    public class Flatrate47 : ProviderOption { }
    public class MT : ProviderDetail<Flatrate48, ProviderOption, ProviderOption> { }
    public class Flatrate48 : ProviderOption { }
    public class MX : ProviderDetail<Flatrate49, ProviderOption, ProviderOption> { }
    public class Flatrate49 : ProviderOption { }
    public class MY : ProviderDetail<Flatrate50, ProviderOption, ProviderOption> { }
    public class Flatrate50 : ProviderOption { }
    public class NI : ProviderDetail<Flatrate51, ProviderOption, ProviderOption> { }
    public class Flatrate51 : ProviderOption { }
    public class NL : ProviderDetail { }
    public class Buy34 : ProviderOption { }
    public class Flatrate52 : ProviderOption { }
    public class Rent25 : ProviderOption { }
    public class NO : ProviderDetail { }
    public class Rent26 : ProviderOption { }
    public class Flatrate53 : ProviderOption { }
    public class Buy35 : ProviderOption { }
    public class NZ : ProviderDetail<Flatrate54, Buy36, ProviderOption> { }
    public class Flatrate54 : ProviderOption { } 
    public class Buy36 : ProviderOption { } 
    public class PA : ProviderDetail<Flatrate55, ProviderOption, ProviderOption> { }
    public class Flatrate55 : ProviderOption { } 
    public class PE : ProviderDetail<Flatrate56, Buy37, ProviderOption> { }
    public class Buy37 : ProviderOption { } 
    public class Flatrate56 : ProviderOption { } 
    public class PH : ProviderDetail<Flatrate57, ProviderOption, ProviderOption> { }
    public class Flatrate57 : ProviderOption { } 
    public class PL : ProviderDetail { }
    public class Rent27 : ProviderOption { } 
    public class Flatrate58 : ProviderOption { } 
    public class Buy38 : ProviderOption { } 
    public class PT : ProviderDetail { }
    public class Buy39 : ProviderOption { } 
    public class Rent28 : ProviderOption { } 
    public class Flatrate59 : ProviderOption { } 
    public class PY : ProviderDetail<Flatrate60, ProviderOption, ProviderOption> { }
    public class Flatrate60 : ProviderOption { } 
    public class RO : ProviderDetail<Flatrate61, ProviderOption, ProviderOption> { }
    public class Flatrate61 : ProviderOption { } 
    public class RS : ProviderDetail<Flatrate62, ProviderOption, ProviderOption> { }
    public class Flatrate62 : ProviderOption { } 
    public class RU : ProviderDetail<Flatrate63, Buy40, ProviderOption> { }
    public class Buy40 : ProviderOption { }   
    public class Flatrate63 : ProviderOption { }        
    public class SA : ProviderDetail<ProviderOption, Buy41, Rent29> { }
    public class Buy41 : ProviderOption { }        
    public class Rent29 : ProviderOption { }    
    public class SE : ProviderDetail { }
    public class Buy42 : ProviderOption { }
    public class Flatrate64 : ProviderOption { }
    public class Rent30 : ProviderOption { }        
    public class SG : ProviderDetail<Flatrate65, ProviderOption, ProviderOption> { }
    public class Flatrate65 : ProviderOption { }
    public class SI : ProviderDetail { }
    public class Rent31 : ProviderOption { }
    public class Flatrate66 : ProviderOption { }        
    public class Buy43 : ProviderOption { }     
    public class SK : ProviderDetail { }
    public class Rent32 : ProviderOption { }
    public class Buy44 : ProviderOption { }
    public class Flatrate67 : ProviderOption { }
    public class SM : ProviderDetail<Flatrate68, ProviderOption, ProviderOption> { }
    public class Flatrate68 : ProviderOption { }
    public class SV : ProviderDetail<Flatrate69, ProviderOption, ProviderOption> { }
    public class Flatrate69 : ProviderOption { }
    public class TH : ProviderDetail<Flatrate70, ProviderOption, ProviderOption> { }
    public class Flatrate70 : ProviderOption { }
    public class TR : ProviderDetail { }
    public class Flatrate71 : ProviderOption { }
    public class Buy45 : ProviderOption { }
    public class Rent33 : ProviderOption { }
    public class TT : ProviderDetail<Flatrate72, ProviderOption, ProviderOption> { }
    public class Flatrate72 : ProviderOption { }
    public class TW : ProviderDetail<Flatrate73, ProviderOption, ProviderOption> { }
    public class Flatrate73 : ProviderOption { }
    public class UA : ProviderDetail<ProviderOption, Buy46, Rent34> { }
    public class Buy46 : ProviderOption { }
    public class Rent34 : ProviderOption { }
    public class US : ProviderDetail { }
    public class Flatrate74 : ProviderOption { }
    public class Rent35 : ProviderOption { }
    public class Buy47 : ProviderOption { }
    public class UY : ProviderDetail<Flatrate75, ProviderOption, ProviderOption> { }
    public class Flatrate75 : ProviderOption { }
    public class VE : ProviderDetail<Flatrate76, Buy48, ProviderOption> { }
    public class Flatrate76 : ProviderOption { }
    public class Buy48 : ProviderOption { }
    public class ZA : ProviderDetail<ProviderOption, Buy49, Rent36> { }
    public class Buy49 : ProviderOption { }
    public class Rent36 : ProviderOption { }
}

