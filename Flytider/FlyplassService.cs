using System.Collections.Generic;

namespace Flytider
{
    public class FlyplassService
    {
        public IEnumerable<Flyplass> HentFlyplasser()
        {
            yield return new Flyplass("ALF", "Alta", 69.9792675, 23.3570997);
            yield return new Flyplass("ANX", "Andøya", 69.2925, 16.144167);
            yield return new Flyplass("BDU", "Bardufoss", 69.0589355, 18.5389993);
            yield return new Flyplass("BGO", "Bergen", 60.2907413, 5.2206527);
            yield return new Flyplass("BVG", "Berlevåg", 70.8702268, 29.029401);
            yield return new Flyplass("BOO", "Bodø", 67.2709066, 14.365283);
            yield return new Flyplass("BNN", "Brønnøysund", 65.4619612, 12.2160506);
            yield return new Flyplass("BJF", "Båtsfjord", 70.6031278, 29.6947766);
            yield return new Flyplass("DLD", "Dagali", 60.4153251, 8.4994951);
            yield return new Flyplass("VDB", "Fagernes", 61.0105417, 9.2937436);
            yield return new Flyplass("FAN", "Farsund", 58.100277, 6.625);
            yield return new Flyplass("FRO", "Florø", 61.5858537, 5.0248417);
            yield return new Flyplass("FDE", "Førde", 61.3919946, 5.761498);
            yield return new Flyplass("HMR", "Hamar", 60.818611, 11.068055);
            yield return new Flyplass("HFT", "Hammerfest", 70.6807959, 23.6760312);
            yield return new Flyplass("EVE", "Harstad/Narvik", 68.4890355, 16.6805628);
            yield return new Flyplass("HAA", "Hasvik", 70.486667, 22.139722);
            yield return new Flyplass("HAU", "Haugesund", 59.3434459, 5.2124808);
            yield return new Flyplass("HVG", "Honningsvåg", 71.0098801, 25.976753);
            yield return new Flyplass("KKN", "Kirkenes", 69.7259803, 29.8957581);
            yield return new Flyplass("KRS", "Kristiansand", 58.1988125, 8.0779211);
            yield return new Flyplass("KSU", "Kristiansund", 63.1137254, 7.825846);
            yield return new Flyplass("LKL", "Lakselv", 70.0661494, 24.975006);
            yield return new Flyplass("LKN", "Leknes", 68.1563679, 13.6120448);
            yield return new Flyplass("MEH", "Mehamn", 71.029722, 27.82667);
            yield return new Flyplass("MQN", "Mo i Rana", 66.3643543, 14.303553);
            yield return new Flyplass("MOL", "Molde", 62.7466126, 7.263971);
            yield return new Flyplass("MJF", "Mosjøen", 65.783611, 13.215278);
            yield return new Flyplass("RYG", "Moss", 59.379723, 10.784445);
            yield return new Flyplass("OSY", "Namsos", 64.472259, 11.572084);
            yield return new Flyplass("NTB", "Notodden", 59.566387, 9.210278);
            yield return new Flyplass("OSL", "Oslo", 60.194185, 11.100411);
            yield return new Flyplass("RRS", "Røros", 62.576792, 11.35291);
            yield return new Flyplass("RVK", "Rørvik", 64.833161, 11.158013);
            yield return new Flyplass("RET", "Røst", 67.527778, 12.103333);
            yield return new Flyplass("SDN", "Sandane", 61.829613, 6.106278);
            yield return new Flyplass("TRF", "Sandefjord", 59.186667, 10.258611);
            yield return new Flyplass("SSJ", "Sandnessjøen", 65.961167, 12.473971);
            yield return new Flyplass("SKE", "Skien", 59.184445, 9.569323);
            yield return new Flyplass("SOG", "Sogndal", 61.156622, 7.136138);
            yield return new Flyplass("SVG", "Stavanger", 58.892222, 5.7075);
            yield return new Flyplass("SKN", "Stokmarknes", 68.580235, 15.032462);
            yield return new Flyplass("SRP", "Stord", 59.790185, 5.341205);
            yield return new Flyplass("LYR", "Svalbard", 78.246444, 15.49449);
            yield return new Flyplass("SVJ", "Svolvær", 68.24413, 14.666854);
            yield return new Flyplass("SOJ", "Sørkjosen", 69.789828, 20.950255);
            yield return new Flyplass("TOS", "Tromsø", 69.678712, 18.909571);
            yield return new Flyplass("TRD", "Trondheim", 63.457824, 10.922925);
            yield return new Flyplass("VDS", "Vadsø", 70.06527, 29.841601);
            yield return new Flyplass("VAW", "Vardø", 70.35686, 31.047094);
            yield return new Flyplass("VRY", "Værøy", 67.689803, 12.679355);
            yield return new Flyplass("OLA", "Ørland", 63.696038, 9.60463);
            yield return new Flyplass("HOV", "Ørsta/Volda", 62.180405, 6.076237);
            yield return new Flyplass("AES", "Ålesund", 62.560696, 6.111291);
        }
    }
}
