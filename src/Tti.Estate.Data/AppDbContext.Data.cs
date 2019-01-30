using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tti.Estate.Data.Entities;

namespace Tti.Estate.Data
{
    public partial class AppDbContext
    {
        protected void ConfigureCountyData(EntityTypeBuilder<County> builder)
        {
            builder.HasData(
                new County { Id = 2, Code = "RIGA", Name = "Rīga" },
                new County { Id = 4, Code = "JELGAVA", Name = "Jelgava" },
                new County { Id = 6, Code = "LIEPAJA", Name = "Liepāja" },
                new County { Id = 8, Code = "VENTSPILS", Name = "Ventspils" },
                new County { Id = 10, Code = "JURMALA", Name = "Jūrmala" },
                new County { Id = 12, Code = "DAUGAVPILS", Name = "Daugavpils" },
                new County { Id = 14, Code = "REZEKNE", Name = "Rēzekne" },
                new County { Id = 16, Code = "VALMIERA", Name = "Valmiera" },
                new County { Id = 18, Code = "JEKABPILS", Name = "Jēkabpils" },
                new County { Id = 20, Code = "CIBLAS_NOV", Name = "Ciblas nov." },
                new County { Id = 22, Code = "AMATAS_NOV", Name = "Amatas nov." },
                new County { Id = 24, Code = "AIZKRAUKLES_NOV", Name = "Aizkraukles nov." },
                new County { Id = 26, Code = "KRASLAVAS_NOV", Name = "Krāslavas nov." },
                new County { Id = 28, Code = "BROCENU_NOV", Name = "Brocēnu nov." },
                new County { Id = 30, Code = "PREILU_NOV", Name = "Preiļu nov." },
                new County { Id = 32, Code = "DURBES_NOV", Name = "Durbes nov." },
                new County { Id = 34, Code = "VARKAVAS_NOV", Name = "Vārkavas nov." },
                new County { Id = 36, Code = "LIVANU_NOV", Name = "Līvānu nov." },
                new County { Id = 38, Code = "KEGUMA_NOV", Name = "Ķeguma nov." },
                new County { Id = 40, Code = "IECAVAS_NOV", Name = "Iecavas nov." },
                new County { Id = 42, Code = "OGRES_NOV", Name = "Ogres nov." },
                new County { Id = 44, Code = "TERVETES_NOV", Name = "Tērvetes nov." },
                new County { Id = 46, Code = "ZILUPES_NOV", Name = "Zilupes nov." },
                new County { Id = 48, Code = "OZOLNIEKU_NOV", Name = "Ozolnieku nov." },
                new County { Id = 50, Code = "KANDAVAS_NOV", Name = "Kandavas nov." },
                new County { Id = 52, Code = "SIGULDAS_NOV", Name = "Siguldas nov." },
                new County { Id = 54, Code = "ILUKSTES_NOV", Name = "Ilūkstes nov." },
                new County { Id = 56, Code = "IKSKILES_NOV", Name = "Ikšķiles nov." },
                new County { Id = 58, Code = "AGLONAS_NOV", Name = "Aglonas nov." },
                new County { Id = 60, Code = "AIZPUTES_NOV", Name = "Aizputes nov." },
                new County { Id = 62, Code = "AKNISTES_NOV", Name = "Aknīstes nov." },
                new County { Id = 64, Code = "ALOJAS_NOV", Name = "Alojas nov." },
                new County { Id = 66, Code = "ALSUNGAS_NOV", Name = "Alsungas nov." },
                new County { Id = 68, Code = "ALUKSNES_NOV", Name = "Alūksnes nov." },
                new County { Id = 70, Code = "APES_NOV", Name = "Apes nov." },
                new County { Id = 72, Code = "LUBANAS_NOV", Name = "Lubānas nov." },
                new County { Id = 74, Code = "ADAZU_NOV", Name = "Ādažu nov." },
                new County { Id = 76, Code = "CARNIKAVAS_NOV", Name = "Carnikavas nov." },
                new County { Id = 78, Code = "GARKALNES_NOV", Name = "Garkalnes nov." },
                new County { Id = 80, Code = "ROJAS_NOV", Name = "Rojas nov." },
                new County { Id = 82, Code = "MERSRAGA_NOV", Name = "Mērsraga nov." },
                new County { Id = 84, Code = "BALDONES_NOV", Name = "Baldones nov." },
                new County { Id = 86, Code = "AUCES_NOV", Name = "Auces nov." },
                new County { Id = 88, Code = "BABITES_NOV", Name = "Babītes nov." },
                new County { Id = 90, Code = "BALTINAVAS_NOV", Name = "Baltinavas nov." },
                new County { Id = 92, Code = "BALVU_NOV", Name = "Balvu nov." },
                new County { Id = 94, Code = "BAUSKAS_NOV", Name = "Bauskas nov." },
                new County { Id = 96, Code = "BEVERINAS_NOV", Name = "Beverīnas nov." },
                new County { Id = 98, Code = "CESU_NOV", Name = "Cēsu nov." },
                new County { Id = 100, Code = "CESVAINES_NOV", Name = "Cesvaines nov." },
                new County { Id = 102, Code = "DAGDAS_NOV", Name = "Dagdas nov." },
                new County { Id = 104, Code = "DAUGAVPILS_NOV", Name = "Daugavpils nov." },
                new County { Id = 106, Code = "DOBELES_NOV", Name = "Dobeles nov." },
                new County { Id = 108, Code = "DUNDAGAS_NOV", Name = "Dundagas nov." },
                new County { Id = 110, Code = "ENGURES_NOV", Name = "Engures nov." },
                new County { Id = 112, Code = "GROBINAS_NOV", Name = "Grobiņas nov." },
                new County { Id = 114, Code = "GULBENES_NOV", Name = "Gulbenes nov." },
                new County { Id = 116, Code = "JAUNJELGAVAS_NOV", Name = "Jaunjelgavas nov." },
                new County { Id = 118, Code = "JAUNPILS_NOV", Name = "Jaunpils nov." },
                new County { Id = 120, Code = "JEKABPILS_NOV", Name = "Jēkabpils nov." },
                new County { Id = 122, Code = "JELGAVAS_NOV", Name = "Jelgavas nov." },
                new County { Id = 124, Code = "KARSAVAS_NOV", Name = "Kārsavas nov." },
                new County { Id = 126, Code = "KOKNESES_NOV", Name = "Kokneses nov." },
                new County { Id = 128, Code = "KRIMULDAS_NOV", Name = "Krimuldas nov." },
                new County { Id = 130, Code = "KRUSTPILS_NOV", Name = "Krustpils nov." },
                new County { Id = 132, Code = "KULDIGAS_NOV", Name = "Kuldīgas nov." },
                new County { Id = 134, Code = "KEKAVAS_NOV", Name = "Ķekavas nov." },
                new County { Id = 136, Code = "LIGATNES_NOV", Name = "Līgatnes nov." },
                new County { Id = 138, Code = "LIMBAZU_NOV", Name = "Limbažu nov." },
                new County { Id = 140, Code = "LUDZAS_NOV", Name = "Ludzas nov." },
                new County { Id = 142, Code = "MADONAS_NOV", Name = "Madonas nov." },
                new County { Id = 144, Code = "MALPILS_NOV", Name = "Mālpils nov." },
                new County { Id = 146, Code = "MARUPES_NOV", Name = "Mārupes nov." },
                new County { Id = 148, Code = "MAZSALACAS_NOV", Name = "Mazsalacas nov." },
                new County { Id = 150, Code = "NAUKSENU_NOV", Name = "Naukšēnu nov." },
                new County { Id = 152, Code = "NERETAS_NOV", Name = "Neretas nov." },
                new County { Id = 154, Code = "NICAS_NOV", Name = "Nīcas nov." },
                new County { Id = 156, Code = "OLAINES_NOV", Name = "Olaines nov." },
                new County { Id = 158, Code = "PARGAUJAS_NOV", Name = "Pārgaujas nov." },
                new County { Id = 160, Code = "PAVILOSTAS_NOV", Name = "Pāvilostas nov." },
                new County { Id = 162, Code = "PLAVINU_NOV", Name = "Pļaviņu nov." },
                new County { Id = 164, Code = "PRIEKULES_NOV", Name = "Priekules nov." },
                new County { Id = 166, Code = "PRIEKULU_NOV", Name = "Priekuļu nov." },
                new County { Id = 168, Code = "REZEKNES_NOV", Name = "Rēzeknes nov." },
                new County { Id = 170, Code = "RUCAVAS_NOV", Name = "Rucavas nov." },
                new County { Id = 172, Code = "RUGAJU_NOV", Name = "Rugāju nov." },
                new County { Id = 174, Code = "RUNDALES_NOV", Name = "Rundāles nov." },
                new County { Id = 176, Code = "RUJIENAS_NOV", Name = "Rūjienas nov." },
                new County { Id = 178, Code = "SALACGRIVAS_NOV", Name = "Salacgrīvas nov." },
                new County { Id = 180, Code = "SALAS_NOV", Name = "Salas nov." },
                new County { Id = 182, Code = "SALDUS_NOV", Name = "Saldus nov." },
                new County { Id = 184, Code = "SKRIVERU_NOV", Name = "Skrīveru nov." },
                new County { Id = 186, Code = "SKRUNDAS_NOV", Name = "Skrundas nov." },
                new County { Id = 188, Code = "SMILTENES_NOV", Name = "Smiltenes nov." },
                new County { Id = 190, Code = "STRENCU_NOV", Name = "Strenču nov." },
                new County { Id = 192, Code = "TALSU_NOV", Name = "Talsu nov." },
                new County { Id = 194, Code = "TUKUMA_NOV", Name = "Tukuma nov." },
                new County { Id = 196, Code = "VAINODES_NOV", Name = "Vaiņodes nov." },
                new County { Id = 198, Code = "VALKAS_NOV", Name = "Valkas nov." },
                new County { Id = 200, Code = "KOCENU_NOV", Name = "Kocēnu nov." },
                new County { Id = 202, Code = "VARAKLANU_NOV", Name = "Varakļānu nov." },
                new County { Id = 204, Code = "VECPIEBALGAS_NOV", Name = "Vecpiebalgas nov." },
                new County { Id = 206, Code = "VECUMNIEKU_NOV", Name = "Vecumnieku nov." },
                new County { Id = 208, Code = "VENTSPILS_NOV", Name = "Ventspils nov." },
                new County { Id = 210, Code = "VIESITES_NOV", Name = "Viesītes nov." },
                new County { Id = 212, Code = "VILAKAS_NOV", Name = "Viļakas nov." },
                new County { Id = 214, Code = "VILANU_NOV", Name = "Viļānu nov." },
                new County { Id = 216, Code = "BURTNIEKU_NOV", Name = "Burtnieku nov." },
                new County { Id = 218, Code = "ERGLU_NOV", Name = "Ērgļu nov." },
                new County { Id = 220, Code = "SEJAS_NOV", Name = "Sējas nov." },
                new County { Id = 222, Code = "INCUKALNA_NOV", Name = "Inčukalna nov." },
                new County { Id = 224, Code = "JAUNPIEBALGAS_NOV", Name = "Jaunpiebalgas nov." },
                new County { Id = 226, Code = "SAULKRASTU_NOV", Name = "Saulkrastu nov." },
                new County { Id = 228, Code = "RAUNAS_NOV", Name = "Raunas nov." },
                new County { Id = 230, Code = "LIELVARDES_NOV", Name = "Lielvārdes nov." },
                new County { Id = 232, Code = "ROPAZU_NOV", Name = "Ropažu nov." },
                new County { Id = 234, Code = "RIEBINU_NOV", Name = "Riebiņu nov." },
                new County { Id = 236, Code = "STOPINU_NOV", Name = "Stopiņu nov." },
                new County { Id = 238, Code = "SALASPILS_NOV", Name = "Salaspils nov." }
           );
        }
        
        protected void ConfigureCityData(EntityTypeBuilder<City> builder)
        {
            builder.HasData(
                //Rīga
                new City { Id = 1, Code = "AGENSKALNS", Name = "Āgenskalns", CountyId = 2 },
                new City { Id = 2, Code = "APLOKCIEMS", Name = "Aplokciems", CountyId = 2 },
                new City { Id = 3, Code = "BEBERBEKI", Name = "Beberbeki", CountyId = 2 },
                new City { Id = 4, Code = "BERGI", Name = "Berģi", CountyId = 2 },
                new City { Id = 5, Code = "BIERINI", Name = "Bieriņi", CountyId = 2 },
                new City { Id = 6, Code = "BISUMUIZA", Name = "Bišumuiža", CountyId = 2 },
                new City { Id = 7, Code = "BOLDERAJA", Name = "Bolderāja", CountyId = 2 },
                new City { Id = 8, Code = "BUKULTI", Name = "Bukulti", CountyId = 2 },
                new City { Id = 9, Code = "CENTRS", Name = "Centrs", CountyId = 2 },
                new City { Id = 10, Code = "CENTRS", Name = "Centrs", CountyId = 2 },
                new City { Id = 11, Code = "CENTRS", Name = "Centrs", CountyId = 2 },
                new City { Id = 12, Code = "CIEKURKALNS", Name = "Čiekurkalns", CountyId = 2 },
                new City { Id = 13, Code = "DARZCIEMS", Name = "Dārzciems", CountyId = 2 },
                new City { Id = 14, Code = "DARZINI", Name = "Dārziņi", CountyId = 2 },
                new City { Id = 15, Code = "DAUGAVGRIVA", Name = "Daugavgrīva", CountyId = 2 },
                new City { Id = 16, Code = "DREILINI", Name = "Dreiliņi", CountyId = 2 },
                new City { Id = 17, Code = "DZIRCIEMS", Name = "Dzirciems", CountyId = 2 },
                new City { Id = 18, Code = "GRIZINKALNS", Name = "Grīziņkalns", CountyId = 2 },
                new City { Id = 19, Code = "ILGUCIEMS", Name = "Iļģuciems", CountyId = 2 },
                new City { Id = 20, Code = "IMANTA", Name = "Imanta", CountyId = 2 },
                new City { Id = 21, Code = "JAUNCIEMS", Name = "Jaunciems", CountyId = 2 },
                new City { Id = 22, Code = "JAUNMILGRAVIS", Name = "Jaunmīlgrāvis", CountyId = 2 },
                new City { Id = 23, Code = "JUGLA", Name = "Jugla", CountyId = 2 },
                new City { Id = 24, Code = "KATLAKALNS", Name = "Katlakalns", CountyId = 2 },
                new City { Id = 25, Code = "KENGARAGS", Name = "Ķengarags", CountyId = 2 },
                new City { Id = 26, Code = "KIPSALA", Name = "Ķīpsala", CountyId = 2 },
                new City { Id = 27, Code = "KLEISTI", Name = "Kleisti", CountyId = 2 },
                new City { Id = 28, Code = "KLIVERSALA", Name = "Klīversala", CountyId = 2 },
                new City { Id = 29, Code = "KRASTA_MASIVS", Name = "Krasta masīvs", CountyId = 2 },
                new City { Id = 30, Code = "LUCAVSALA", Name = "Lucavsala", CountyId = 2 },
                new City { Id = 31, Code = "MANGALU_PUSSALA", Name = "Mangaļu pussala", CountyId = 2 },
                new City { Id = 32, Code = "MASKAVAS_PRIEKSPILSETA", Name = "Maskavas priekšpilsēta", CountyId = 2 },
                new City { Id = 33, Code = "MEZAPARKS", Name = "Mežaparks", CountyId = 2 },
                new City { Id = 34, Code = "MEZCIEMS", Name = "Mežciems", CountyId = 2 },
                new City { Id = 35, Code = "MUKUSALA", Name = "Mūkusala", CountyId = 2 },
                new City { Id = 36, Code = "OZOLCIEMS", Name = "Ozolciems", CountyId = 2 },
                new City { Id = 37, Code = "PARDAUGAVA", Name = "Pārdaugava", CountyId = 2 },
                new City { Id = 38, Code = "PETERSALA", Name = "Pētersala", CountyId = 2 },
                new City { Id = 39, Code = "PLESKODALE_SAMPETERIS", Name = "Pleskodāle-Šampēteris", CountyId = 2 },
                new City { Id = 40, Code = "PURVCIEMS", Name = "Purvciems", CountyId = 2 },
                new City { Id = 41, Code = "RUMBULA", Name = "Rumbula", CountyId = 2 },
                new City { Id = 42, Code = "SARKANDAUGAVA", Name = "Sarkandaugava", CountyId = 2 },
                new City { Id = 43, Code = "SKIROTAVA", Name = "Šķirotava", CountyId = 2 },
                new City { Id = 44, Code = "SMERLIS", Name = "Šmerlis", CountyId = 2 },
                new City { Id = 45, Code = "TEIKA", Name = "Teika", CountyId = 2 },
                new City { Id = 46, Code = "TORNKALNS", Name = "Torņakalns", CountyId = 2 },
                new City { Id = 47, Code = "VECAKI", Name = "Vecāķi", CountyId = 2 },
                new City { Id = 48, Code = "VECDAUGAVA", Name = "Vecdaugava", CountyId = 2 },
                new City { Id = 49, Code = "VECMILGRAVIS", Name = "Vecmīlgrāvis", CountyId = 2 },
                new City { Id = 50, Code = "VECRIGA", Name = "Vecrīga", CountyId = 2 },
                new City { Id = 51, Code = "ZAKUSALA", Name = "Zaķusala", CountyId = 2 },
                new City { Id = 52, Code = "ZASULAUKS", Name = "Zasulauks", CountyId = 2 },
                new City { Id = 53, Code = "ZIEPNIEKKALNS", Name = "Ziepniekkalns", CountyId = 2 },
                new City { Id = 54, Code = "ZOLITUDE", Name = "Zolitūde", CountyId = 2 },
                new City { Id = 55, Code = "PLAVNIEKI", Name = "Pļavnieki", CountyId = 2 },

                //Jelgava
                new City { Id = 56, Code = "JELGAVA", Name = "Jelgava", CountyId = 4 },

                //Liepāja
                new City { Id = 57, Code = "LIEPAJA", Name = "Liepāja", CountyId = 6 },

                //Ventspils
                new City { Id = 58, Code = "VENTSPILS", Name = "Ventspils", CountyId = 8 },

                //Jūrmala
                new City { Id = 59, Code = "JURMALA", Name = "Jūrmala", CountyId = 10 },
                new City { Id = 60, Code = "ASARI", Name = "Asari", CountyId = 10 },
                new City { Id = 61, Code = "BULDURI", Name = "Bulduri", CountyId = 10 },
                new City { Id = 62, Code = "BULLUCIEMS", Name = "Buļļuciems", CountyId = 10 },
                new City { Id = 63, Code = "DRUVCIEMS", Name = "Druvciems", CountyId = 10 },
                new City { Id = 64, Code = "DUBULTI", Name = "Dubulti", CountyId = 10 },
                new City { Id = 65, Code = "DZINTARI", Name = "Dzintari", CountyId = 10 },
                new City { Id = 66, Code = "JAUNDUBULTI", Name = "Jaundubulti", CountyId = 10 },
                new City { Id = 67, Code = "JAUNKEMERI", Name = "Jaunķemeri", CountyId = 10 },
                new City { Id = 68, Code = "KAUGURCIEMS", Name = "Kaugurciems", CountyId = 10 },
                new City { Id = 69, Code = "KAUGURI", Name = "Kauguri", CountyId = 10 },
                new City { Id = 70, Code = "KEMERI", Name = "Ķemeri", CountyId = 10 },
                new City { Id = 71, Code = "LIELUPE", Name = "Lielupe", CountyId = 10 },
                new City { Id = 72, Code = "MAJORI", Name = "Majori", CountyId = 10 },
                new City { Id = 73, Code = "MELLUZI", Name = "Melluži", CountyId = 10 },
                new City { Id = 74, Code = "PRIEDAINE", Name = "Priedaine", CountyId = 10 },
                new City { Id = 75, Code = "PUMPURI", Name = "Pumpuri", CountyId = 10 },
                new City { Id = 76, Code = "SLOKA", Name = "Sloka", CountyId = 10 },
                new City { Id = 77, Code = "VAIVARI", Name = "Vaivari", CountyId = 10 },
                new City { Id = 78, Code = "VALTERI", Name = "Valteri", CountyId = 10 },

                //Daugavpils
                new City { Id = 79, Code = "DAUGAVPILS", Name = "Daugavpils", CountyId = 12 },

                //Rēzekne
                new City { Id = 80, Code = "REZEKNE", Name = "Rēzekne", CountyId = 14 },

                //Valmiera
                new City { Id = 81, Code = "VALMIERA", Name = "Valmiera", CountyId = 16 },

                //Jēkabpils
                new City { Id = 82, Code = "JEKABPILS", Name = "Jēkabpils", CountyId = 18 },

                //Ciblas nov.
                new City { Id = 83, Code = "ZVIRGZDENES_PAG", Name = "Zvirgzdenes pag.", CountyId = 20 },
                new City { Id = 84, Code = "BLONTU_PAG", Name = "Blontu pag.", CountyId = 20 },
                new City { Id = 85, Code = "LIDUMNIEKU_PAG", Name = "Līdumnieku pag.", CountyId = 20 },
                new City { Id = 86, Code = "CIBLAS_PAG", Name = "Ciblas pag.", CountyId = 20 },
                new City { Id = 87, Code = "PUSMUCOVAS_PAG", Name = "Pušmucovas pag.", CountyId = 20 },

                //Amatas nov.
                new City { Id = 88, Code = "DRABESU_PAG", Name = "Drabešu pag.", CountyId = 22 },
                new City { Id = 89, Code = "ZAUBES_PAG", Name = "Zaubes pag.", CountyId = 22 },
                new City { Id = 90, Code = "SKUJENES_PAG", Name = "Skujenes pag.", CountyId = 22 },
                new City { Id = 91, Code = "NITAURES_PAG", Name = "Nītaures pag.", CountyId = 22 },
                new City { Id = 92, Code = "AMATAS_PAG", Name = "Amatas pag.", CountyId = 22 },
                new City { Id = 93, Code = "LIVI", Name = "Līvi", CountyId = 22 },

                //Aizkraukles nov.
                new City { Id = 94, Code = "AIZKRAUKLE", Name = "Aizkraukle", CountyId = 24 },
                new City { Id = 95, Code = "AIZKRAUKLES_PAG", Name = "Aizkraukles pag.", CountyId = 24 },

                //Krāslavas nov.
                new City { Id = 96, Code = "KRASLAVA", Name = "Krāslava", CountyId = 26 },
                new City { Id = 97, Code = "KRASLAVAS_PAG", Name = "Krāslavas pag.", CountyId = 26 },
                new City { Id = 98, Code = "SKAISTAS_PAG", Name = "Skaistas pag.", CountyId = 26 },
                new City { Id = 99, Code = "UDRISU_PAG", Name = "Ūdrīšu pag.", CountyId = 26 },
                new City { Id = 100, Code = "KOMBULU_PAG", Name = "Kombuļu pag.", CountyId = 26 },
                new City { Id = 101, Code = "ROBEZNIEKU_PAG", Name = "Robežnieku pag.", CountyId = 26 },
                new City { Id = 102, Code = "INDRAS_PAG", Name = "Indras pag.", CountyId = 26 },
                new City { Id = 103, Code = "KALNIESU_PAG", Name = "Kalniešu pag.", CountyId = 26 },
                new City { Id = 104, Code = "IZVALTAS_PAG", Name = "Izvaltas pag.", CountyId = 26 },
                new City { Id = 105, Code = "KAPLAVAS_PAG", Name = "Kaplavas pag.", CountyId = 26 },
                new City { Id = 106, Code = "PIEDRUJAS_PAG", Name = "Piedrujas pag.", CountyId = 26 },
                new City { Id = 107, Code = "AULEJAS_PAG", Name = "Aulejas pag.", CountyId = 26 },
                new City { Id = 108, Code = "INDRA", Name = "Indra", CountyId = 26 },

                //Brocēnu nov.
                new City { Id = 109, Code = "BROCENI", Name = "Brocēni", CountyId = 28 },
                new City { Id = 110, Code = "REMTES_PAG", Name = "Remtes pag.", CountyId = 28 },
                new City { Id = 111, Code = "BLIDENES_PAG", Name = "Blīdenes pag.", CountyId = 28 },
                new City { Id = 112, Code = "GAIKU_PAG", Name = "Gaiķu pag.", CountyId = 28 },
                new City { Id = 113, Code = "CIECERES_PAG", Name = "Cieceres pag.", CountyId = 28 },

                //Preiļu nov.
                new City { Id = 114, Code = "PREILI", Name = "Preiļi", CountyId = 30 },
                new City { Id = 115, Code = "AIZKALNES_PAG", Name = "Aizkalnes pag.", CountyId = 30 },
                new City { Id = 116, Code = "PREILU_PAG", Name = "Preiļu pag.", CountyId = 30 },
                new City { Id = 117, Code = "SAUNAS_PAG", Name = "Saunas pag.", CountyId = 30 },
                new City { Id = 118, Code = "PELECU_PAG", Name = "Pelēču pag.", CountyId = 30 },

                //Durbes nov.
                new City { Id = 119, Code = "DURBE", Name = "Durbe", CountyId = 32 },
                new City { Id = 120, Code = "DURBES_PAG", Name = "Durbes pag.", CountyId = 32 },
                new City { Id = 121, Code = "VECPILS_PAG", Name = "Vecpils pag.", CountyId = 32 },
                new City { Id = 122, Code = "DUNALKAS_PAG", Name = "Dunalkas pag.", CountyId = 32 },
                new City { Id = 123, Code = "TADAIKU_PAG", Name = "Tadaiķu pag.", CountyId = 32 },

                //Vārkavas nov.
                new City { Id = 124, Code = "UPMALAS_PAG", Name = "Upmalas pag.", CountyId = 34 },
                new City { Id = 125, Code = "ROZKALNU_PAG", Name = "Rožkalnu pag.", CountyId = 34 },
                new City { Id = 126, Code = "VARKAVAS_PAG", Name = "Vārkavas pag.", CountyId = 34 },

                //Līvānu nov.
                new City { Id = 127, Code = "LIVANI", Name = "Līvāni", CountyId = 36 },
                new City { Id = 128, Code = "ROZUPES_PAG", Name = "Rožupes pag.", CountyId = 36 },
                new City { Id = 129, Code = "SUTRU_PAG", Name = "Sutru pag.", CountyId = 36 },
                new City { Id = 130, Code = "RUDZATU_PAG", Name = "Rudzātu pag.", CountyId = 36 },
                new City { Id = 131, Code = "TURKU_PAG", Name = "Turku pag.", CountyId = 36 },
                new City { Id = 132, Code = "JERSIKAS_PAG", Name = "Jersikas pag.", CountyId = 36 },

                //Ķeguma nov.
                new City { Id = 133, Code = "KEGUMS", Name = "Ķegums", CountyId = 38 },
                new City { Id = 134, Code = "TOMES_PAG", Name = "Tomes pag.", CountyId = 38 },
                new City { Id = 135, Code = "BIRZGALES_PAG", Name = "Birzgales pag.", CountyId = 38 },
                new City { Id = 136, Code = "REMBATES_PAG", Name = "Rembates pag.", CountyId = 38 },

                //Iecavas nov.
                new City { Id = 137, Code = "MISA", Name = "Misa", CountyId = 40 },
                new City { Id = 138, Code = "DZIMTMISA", Name = "Dzimtmisa", CountyId = 40 },
                new City { Id = 139, Code = "DIMZUKALNS", Name = "Dimzukalns", CountyId = 40 },
                new City { Id = 140, Code = "ZALITE", Name = "Zālīte", CountyId = 40 },
                new City { Id = 141, Code = "DZELZAMURS", Name = "Dzelzāmurs", CountyId = 40 },
                new City { Id = 142, Code = "ROSME", Name = "Rosme", CountyId = 40 },
                new City { Id = 143, Code = "IECAVA", Name = "Iecava", CountyId = 40 },
                new City { Id = 144, Code = "ZORGI", Name = "Zorģi", CountyId = 40 },
                new City { Id = 145, Code = "AUDRUPI", Name = "Audrupi", CountyId = 40 },

                //Ogres nov.
                new City { Id = 146, Code = "OGRE", Name = "Ogre", CountyId = 42 },
                new City { Id = 147, Code = "KEIPENES_PAG", Name = "Ķeipenes pag.", CountyId = 42 },
                new City { Id = 148, Code = "OGRESGALA_PAG", Name = "Ogresgala pag.", CountyId = 42 },
                new City { Id = 149, Code = "TAURUPES_PAG", Name = "Taurupes pag.", CountyId = 42 },
                new City { Id = 150, Code = "MADLIENAS_PAG", Name = "Madlienas pag.", CountyId = 42 },
                new City { Id = 151, Code = "KRAPES_PAG", Name = "Krapes pag.", CountyId = 42 },
                new City { Id = 152, Code = "MAZOZOLU_PAG", Name = "Mazozolu pag.", CountyId = 42 },
                new City { Id = 153, Code = "SUNTAZU_PAG", Name = "Suntažu pag.", CountyId = 42 },
                new City { Id = 154, Code = "LAUBERES_PAG", Name = "Lauberes pag.", CountyId = 42 },
                new City { Id = 155, Code = "MENGELES_PAG", Name = "Meņģeles pag.", CountyId = 42 },
                new City { Id = 156, Code = "OGRESGALS", Name = "Ogresgals", CountyId = 42 },

                //Tērvetes nov.
                new City { Id = 157, Code = "TERVETES_PAG", Name = "Tērvetes pag.", CountyId = 44 },
                new City { Id = 158, Code = "BUKAISU_PAG", Name = "Bukaišu pag.", CountyId = 44 },
                new City { Id = 159, Code = "AUGSTKALNES_PAG", Name = "Augstkalnes pag.", CountyId = 44 },

                //Zilupes nov.
                new City { Id = 160, Code = "ZILUPE", Name = "Zilupe", CountyId = 46 },
                new City { Id = 161, Code = "PASIENES_PAG", Name = "Pasienes pag.", CountyId = 46 },
                new City { Id = 162, Code = "ZALESJES_PAG", Name = "Zaļesjes pag.", CountyId = 46 },
                new City { Id = 163, Code = "LAUDERU_PAG", Name = "Lauderu pag.", CountyId = 46 },

                //Ozolnieku nov.
                new City { Id = 164, Code = "CENU_PAG", Name = "Cenu pag.", CountyId = 48 },
                new City { Id = 165, Code = "SALGALES_PAG", Name = "Salgales pag.", CountyId = 48 },
                new City { Id = 166, Code = "OZOLNIEKU_PAG", Name = "Ozolnieku pag.", CountyId = 48 },
                new City { Id = 167, Code = "OZOLNIEKI", Name = "Ozolnieki", CountyId = 48 },

                //Kandavas nov.
                new City { Id = 168, Code = "KANDAVA", Name = "Kandava", CountyId = 50 },
                new City { Id = 169, Code = "VANES_PAG", Name = "Vānes pag.", CountyId = 50 },
                new City { Id = 170, Code = "ZEMITES_PAG", Name = "Zemītes pag.", CountyId = 50 },
                new City { Id = 171, Code = "ZANTES_PAG", Name = "Zantes pag.", CountyId = 50 },
                new City { Id = 172, Code = "MATKULES_PAG", Name = "Matkules pag.", CountyId = 50 },
                new City { Id = 173, Code = "KANDAVAS_PAG", Name = "Kandavas pag.", CountyId = 50 },
                new City { Id = 174, Code = "CERES_PAG", Name = "Cēres pag.", CountyId = 50 },

                //Siguldas nov.
                new City { Id = 175, Code = "SIGULDA", Name = "Sigulda", CountyId = 52 },
                new City { Id = 176, Code = "SIGULDAS_PAG", Name = "Siguldas pag.", CountyId = 52 },
                new City { Id = 177, Code = "ALLAZU_PAG", Name = "Allažu pag.", CountyId = 52 },
                new City { Id = 178, Code = "MORES_PAG", Name = "Mores pag.", CountyId = 52 },
                new City { Id = 179, Code = "PELTES", Name = "Peltes", CountyId = 52 },
                new City { Id = 180, Code = "EGLUPE", Name = "Egļupe", CountyId = 52 },

                //Ilūkstes nov.
                new City { Id = 181, Code = "ILUKSTE", Name = "Ilūkste", CountyId = 54 },
                new City { Id = 182, Code = "SUBATE", Name = "Subate", CountyId = 54 },
                new City { Id = 183, Code = "EGLAINES_PAG", Name = "Eglaines pag.", CountyId = 54 },
                new City { Id = 184, Code = "BEBRENES_PAG", Name = "Bebrenes pag.", CountyId = 54 },
                new City { Id = 185, Code = "DVIETES_PAG", Name = "Dvietes pag.", CountyId = 54 },
                new City { Id = 186, Code = "PILSKALNES_PAG", Name = "Pilskalnes pag.", CountyId = 54 },
                new City { Id = 187, Code = "PRODES_PAG", Name = "Prodes pag.", CountyId = 54 },
                new City { Id = 188, Code = "SEDERES_PAG", Name = "Šēderes pag.", CountyId = 54 },

                //Ikšķiles nov.
                new City { Id = 189, Code = "IKSKILE", Name = "Ikšķile", CountyId = 56 },
                new City { Id = 190, Code = "TINUZU_PAG", Name = "Tīnūžu pag.", CountyId = 56 },
                new City { Id = 191, Code = "DAUGAVMALA", Name = "Daugavmala", CountyId = 56 },
                new City { Id = 192, Code = "JAUNIKSKILE", Name = "Jaunikšķile", CountyId = 56 },
                new City { Id = 193, Code = "ADAMLAUKS", Name = "Ādamlauks", CountyId = 56 },

                //Aglonas nov.
                new City { Id = 194, Code = "KASTULINAS_PAG", Name = "Kastuļinas pag.", CountyId = 58 },
                new City { Id = 195, Code = "GRAVERU_PAG", Name = "Grāveru pag.", CountyId = 58 },
                new City { Id = 196, Code = "AGLONAS_PAG", Name = "Aglonas pag.", CountyId = 58 },
                new City { Id = 197, Code = "SKELTOVAS_PAG", Name = "Šķeltovas pag.", CountyId = 58 },
                new City { Id = 198, Code = "AGLONA", Name = "Aglona", CountyId = 58 },

                //Aizputes nov.
                new City { Id = 199, Code = "AIZPUTE", Name = "Aizpute", CountyId = 60 },
                new City { Id = 200, Code = "CIRAVAS_PAG", Name = "Cīravas pag.", CountyId = 60 },
                new City { Id = 201, Code = "AIZPUTES_PAG", Name = "Aizputes pag.", CountyId = 60 },
                new City { Id = 202, Code = "KALVENES_PAG", Name = "Kalvenes pag.", CountyId = 60 },
                new City { Id = 203, Code = "LAZAS_PAG", Name = "Lažas pag.", CountyId = 60 },
                new City { Id = 204, Code = "KAZDANGAS_PAG", Name = "Kazdangas pag.", CountyId = 60 },

                //Aknīstes nov.
                new City { Id = 205, Code = "AKNISTE", Name = "Aknīste", CountyId = 62 },
                new City { Id = 206, Code = "AKNISTES_PAG", Name = "Aknīstes pag.", CountyId = 62 },
                new City { Id = 207, Code = "GARSENES_PAG", Name = "Gārsenes pag.", CountyId = 62 },
                new City { Id = 208, Code = "ASARES_PAG", Name = "Asares pag.", CountyId = 62 },

                //Alojas nov.
                new City { Id = 209, Code = "STAICELE", Name = "Staicele", CountyId = 64 },
                new City { Id = 210, Code = "ALOJA", Name = "Aloja", CountyId = 64 },
                new City { Id = 211, Code = "BRASLAVAS_PAG", Name = "Braslavas pag.", CountyId = 64 },
                new City { Id = 212, Code = "BRIVZEMNIEKU_PAG", Name = "Brīvzemnieku pag.", CountyId = 64 },
                new City { Id = 213, Code = "STAICELES_PAG", Name = "Staiceles pag.", CountyId = 64 },
                new City { Id = 214, Code = "ALOJAS_PAG", Name = "Alojas pag.", CountyId = 64 },

                //Alsungas nov.
                new City { Id = 215, Code = "DIENVIDSTACIJA", Name = "Dienvidstacija", CountyId = 66 },
                new City { Id = 216, Code = "REGI", Name = "Reģi", CountyId = 66 },
                new City { Id = 217, Code = "GRAVERI", Name = "Grāveri", CountyId = 66 },
                new City { Id = 218, Code = "BERZKALNI", Name = "Bērzkalni", CountyId = 66 },
                new City { Id = 219, Code = "ZIEDLEJAS", Name = "Ziedlejas", CountyId = 66 },
                new City { Id = 220, Code = "BUCMANCIEMS", Name = "Būcmaņciems", CountyId = 66 },
                new City { Id = 221, Code = "ALMALE", Name = "Almāle", CountyId = 66 },
                new City { Id = 222, Code = "ALSUNGA", Name = "Alsunga", CountyId = 66 },
                new City { Id = 223, Code = "BALANDE", Name = "Balande", CountyId = 66 },

                //Alūksnes nov.
                new City { Id = 224, Code = "ALUKSNE", Name = "Alūksne", CountyId = 68 },
                new City { Id = 225, Code = "MāLUPES_PAG", Name = "Mālupes pag.", CountyId = 68 },
                new City { Id = 226, Code = "PADEDZES_PAG", Name = "Pededzes pag.", CountyId = 68 },
                new City { Id = 227, Code = "JAUNALUKSNES_PAG", Name = "Jaunalūksnes pag.", CountyId = 68 },
                new City { Id = 228, Code = "ZIEMERA_PAG", Name = "Ziemera pag.", CountyId = 68 },
                new City { Id = 229, Code = "ALSVIKU_PAG", Name = "Alsviķu pag.", CountyId = 68 },
                new City { Id = 230, Code = "JAUNANNAS_PAG", Name = "Jaunannas pag.", CountyId = 68 },
                new City { Id = 231, Code = "LIEPNAS_PAG", Name = "Liepnas pag.", CountyId = 68 },
                new City { Id = 232, Code = "VECLAICENES_PAG", Name = "Veclaicenes pag.", CountyId = 68 },
                new City { Id = 233, Code = "JAUNLAICENES_PAG", Name = "Jaunlaicenes pag.", CountyId = 68 },
                new City { Id = 234, Code = "MALIENAS_PAG", Name = "Malienas pag.", CountyId = 68 },
                new City { Id = 235, Code = "KALNCEMPJU_PAG", Name = "Kalncempju pag.", CountyId = 68 },
                new City { Id = 236, Code = "MARKALNES_PAG", Name = "Mārkalnes pag.", CountyId = 68 },
                new City { Id = 237, Code = "ILZENES_PAG", Name = "Ilzenes pag.", CountyId = 68 },
                new City { Id = 238, Code = "ANNAS_PAG", Name = "Annas pag.", CountyId = 68 },
                new City { Id = 239, Code = "ZELTINU_PAG", Name = "Zeltiņu pag.", CountyId = 68 },

                //Apes nov.
                new City { Id = 240, Code = "APE", Name = "Ape", CountyId = 70 },
                new City { Id = 241, Code = "GAUJIENAS_PAG", Name = "Gaujienas pag.", CountyId = 70 },
                new City { Id = 242, Code = "VIRESU_PAG", Name = "Virešu pag.", CountyId = 70 },
                new City { Id = 243, Code = "TRAPENES_PAG", Name = "Trapenes pag.", CountyId = 70 },
                new City { Id = 244, Code = "APES_PAG", Name = "Apes pag.", CountyId = 70 },

                //Lubānas nov.
                new City { Id = 245, Code = "LUBANA", Name = "Lubāna", CountyId = 72 },
                new City { Id = 246, Code = "INDRANU_PAG", Name = "Indrānu pag.", CountyId = 72 },

                //Ādažu nov.
                new City { Id = 247, Code = "ADAZI", Name = "Ādaži", CountyId = 74 },
                new City { Id = 248, Code = "ILKENE", Name = "Iļķene", CountyId = 74 },
                new City { Id = 249, Code = "ALDERI", Name = "Alderi", CountyId = 74 },
                new City { Id = 250, Code = "ANI", Name = "Āņi", CountyId = 74 },
                new City { Id = 251, Code = "GARKALNE", Name = "Garkalne", CountyId = 74 },
                new City { Id = 252, Code = "STAPRINI", Name = "Stapriņi", CountyId = 74 },
                new City { Id = 253, Code = "ATARI", Name = "Atari", CountyId = 74 },
                new City { Id = 254, Code = "DIVEZERI", Name = "Divezeri", CountyId = 74 },
                new City { Id = 255, Code = "BIRZNIEKI", Name = "Birznieki", CountyId = 74 },
                new City { Id = 256, Code = "EIMURI", Name = "Eimuri", CountyId = 74 },
                new City { Id = 257, Code = "KADAGA", Name = "Kadaga", CountyId = 74 },
                new City { Id = 258, Code = "BALTEZERS", Name = "Baltezers", CountyId = 74 },

                //Carnikavas nov.
                new City { Id = 259, Code = "CARNIKAVA", Name = "Carnikava", CountyId = 76 },
                new City { Id = 260, Code = "GAUJA", Name = "Gauja", CountyId = 76 },
                new City { Id = 261, Code = "GARCIEMS", Name = "Garciems", CountyId = 76 },
                new City { Id = 262, Code = "SIGULI", Name = "Siguļi", CountyId = 76 },
                new City { Id = 263, Code = "EIMURI", Name = "Eimuri", CountyId = 76 },
                new City { Id = 264, Code = "MEZCIEMS_CARNIKAVAS", Name = "Mežciems", CountyId = 76 },
                new City { Id = 265, Code = "LAVERI", Name = "Laveri", CountyId = 76 },
                new City { Id = 266, Code = "LILASTE", Name = "Lilaste", CountyId = 76 },
                new City { Id = 267, Code = "GARUPE", Name = "Garupe", CountyId = 76 },
                new City { Id = 268, Code = "MEZGARCIEMS", Name = "Mežgarciems", CountyId = 76 },
                new City { Id = 269, Code = "KALNGALE", Name = "Kalngale", CountyId = 76 },

                //Garkalnes nov.
                new City { Id = 270, Code = "BALTEZERS_GARKALNES", Name = "Baltezers", CountyId = 78 },
                new City { Id = 271, Code = "UPESCIEMS", Name = "Upesciems", CountyId = 78 },
                new City { Id = 272, Code = "AMATNIEKI", Name = "Amatnieki", CountyId = 78 },
                new City { Id = 273, Code = "PRIEDKALNE", Name = "Priedkalne", CountyId = 78 },
                new City { Id = 274, Code = "GARKALNE_GARKALNES", Name = "Garkalne", CountyId = 78 },
                new City { Id = 275, Code = "SUZI", Name = "Suži", CountyId = 78 },
                new City { Id = 276, Code = "SKUKISI", Name = "Skuķīši", CountyId = 78 },
                new City { Id = 277, Code = "MAKSTENIEKI", Name = "Makstenieki", CountyId = 78 },
                new City { Id = 278, Code = "PRIEZLEJAS", Name = "Priežlejas", CountyId = 78 },
                new City { Id = 279, Code = "SUNISI", Name = "Sunīši", CountyId = 78 },
                new City { Id = 280, Code = "LANGSTINI", Name = "Langstiņi", CountyId = 78 },
                new City { Id = 281, Code = "BUKULTI_GARKALNES", Name = "Bukulti", CountyId = 78 },

                //Rojas nov.
                new City { Id = 282, Code = "ROJA", Name = "Roja", CountyId = 80 },
                new City { Id = 283, Code = "MELNSILS", Name = "Melnsils", CountyId = 80 },
                new City { Id = 284, Code = "ZOCENE", Name = "Žocene", CountyId = 80 },
                new City { Id = 285, Code = "AIZKLANI", Name = "Aizklāņi", CountyId = 80 },
                new City { Id = 286, Code = "VALGALCIEMS", Name = "Valgalciems", CountyId = 80 },
                new City { Id = 287, Code = "PURCIEMS", Name = "Pūrciems", CountyId = 80 },
                new City { Id = 288, Code = "KALTENE", Name = "Kaltene", CountyId = 80 },
                new City { Id = 289, Code = "APSUCIEMS", Name = "Apšuciems", CountyId = 80 },
                new City { Id = 290, Code = "RUDE", Name = "Rude", CountyId = 80 },
                new City { Id = 291, Code = "GIPKA", Name = "Ģipka", CountyId = 80 },

                //Mērsraga nov.
                new City { Id = 292, Code = "UPESGRIVA", Name = "Upesgrīva", CountyId = 82 },
                new City { Id = 293, Code = "ALKSNAJI", Name = "Alksnāji", CountyId = 82 },
                new City { Id = 294, Code = "KIPATI", Name = "Ķipati", CountyId = 82 },
                new City { Id = 295, Code = "MERSRAGS", Name = "Mērsrags", CountyId = 82 },

                //Baldones nov.
                new City { Id = 296, Code = "BALDONE", Name = "Baldone", CountyId = 84 },
                new City { Id = 297, Code = "BALDONES_PAG", Name = "Baldones pag.", CountyId = 84 },
                new City { Id = 298, Code = "AVOTI", Name = "Avoti", CountyId = 84 },

                //Auces nov.
                new City { Id = 299, Code = "AUCE", Name = "Auce", CountyId = 86 },
                new City { Id = 300, Code = "BENES_PAG", Name = "Bēnes pag.", CountyId = 86 },
                new City { Id = 301, Code = "ILES_PAG", Name = "Īles pag.", CountyId = 86 },
                new City { Id = 302, Code = "VITINU_PAG", Name = "Vītiņu pag.", CountyId = 86 },
                new City { Id = 303, Code = "VECAUCES_PAG", Name = "Vecauces pag.", CountyId = 86 },
                new City { Id = 304, Code = "LIELAUCES_PAG", Name = "Lielauces pag.", CountyId = 86 },
                new City { Id = 305, Code = "UKRU_PAG", Name = "Ukru pag.", CountyId = 86 },
                new City { Id = 306, Code = "BENE", Name = "Bēne", CountyId = 86 },

                //Babītes nov.
                new City { Id = 307, Code = "BABITES_PAG", Name = "Babītes pag.", CountyId = 88 },
                new City { Id = 308, Code = "BABITE", Name = "Babīte", CountyId = 88 },
                new City { Id = 309, Code = "SALAS_PAG", Name = "Salas pag.", CountyId = 88 },
                new City { Id = 310, Code = "PINKI", Name = "Piņķi", CountyId = 88 },
                new City { Id = 311, Code = "MEZARES", Name = "Mežāres", CountyId = 88 },
                new City { Id = 312, Code = "SPILVE", Name = "Spilve", CountyId = 88 },

                //Baltinavas nov.
                new City { Id = 313, Code = "BALTINAVA", Name = "Baltinava", CountyId = 90 },

                //Balvu nov.
                new City { Id = 314, Code = "BALVI", Name = "Balvi", CountyId = 92 },
                new City { Id = 315, Code = "BERZPILS_PAG", Name = "Bērzpils pag.", CountyId = 92 },
                new City { Id = 316, Code = "LAZDULEJAS_PAG", Name = "Lazdulejas pag.", CountyId = 92 },
                new City { Id = 317, Code = "VIKSNAS_PAG", Name = "Vīksnas pag.", CountyId = 92 },
                new City { Id = 318, Code = "KUBULU_PAG", Name = "Kubulu pag.", CountyId = 92 },
                new City { Id = 319, Code = "KRISJANU_PAG", Name = "Krišjāņu pag.", CountyId = 92 },
                new City { Id = 320, Code = "BALVU_PAG", Name = "Balvu pag.", CountyId = 92 },
                new City { Id = 321, Code = "VECTILZAS_PAG", Name = "Vectilžas pag.", CountyId = 92 },
                new City { Id = 322, Code = "TILZAS_PAG", Name = "Tilžas pag.", CountyId = 92 },
                new City { Id = 323, Code = "BRIEZUCIEMA_PAG", Name = "Briežuciema pag.", CountyId = 92 },
                new City { Id = 324, Code = "BERZKALNES_PAG", Name = "Bērzkalnes pag.", CountyId = 92 },

                //Bauskas nov.
                new City { Id = 325, Code = "BAUSKA", Name = "Bauska", CountyId = 94 },
                new City { Id = 326, Code = "CERAUKSTES_PAG", Name = "Ceraukstes pag.", CountyId = 94 },
                new City { Id = 327, Code = "DAVINU_PAG", Name = "Dāviņu pag.", CountyId = 94 },
                new City { Id = 328, Code = "CODES_PAG", Name = "Codes pag.", CountyId = 94 },
                new City { Id = 329, Code = "ISLICES_PAG", Name = "Īslīces pag.", CountyId = 94 },
                new City { Id = 330, Code = "VECSAULES_PAG", Name = "Vecsaules pag.", CountyId = 94 },
                new City { Id = 331, Code = "GAILISU_PAG", Name = "Gailīšu pag.", CountyId = 94 },
                new City { Id = 332, Code = "BRUNAVAS_PAG", Name = "Brunavas pag.", CountyId = 94 },
                new City { Id = 333, Code = "MEZOTNES_PAG", Name = "Mežotnes pag.", CountyId = 94 },

                //Beverīnas nov.
                new City { Id = 334, Code = "TRIKATAS_PAG", Name = "Trikātas pag.", CountyId = 96 },
                new City { Id = 335, Code = "KAUGURU_PAG", Name = "Kauguru pag.", CountyId = 96 },
                new City { Id = 336, Code = "BRENGULU_PAG", Name = "Brenguļu pag.", CountyId = 96 },

                //Cēsu nov.
                new City { Id = 337, Code = "CESIS", Name = "Cēsis", CountyId = 98 },
                new City { Id = 338, Code = "VAIVES_PAG", Name = "Vaives pag.", CountyId = 98 },

                //Cesvaines nov.
                new City { Id = 339, Code = "CESVAINE", Name = "Cesvaine", CountyId = 100 },
                new City { Id = 340, Code = "CESVAINES_PAG", Name = "Cesvaines pag.", CountyId = 100 },

                //Dagdas nov.
                new City { Id = 341, Code = "DAGDA", Name = "Dagda", CountyId = 102 },
                new City { Id = 342, Code = "ASUNES_PAG", Name = "Asūnes pag.", CountyId = 102 },
                new City { Id = 343, Code = "EZERNIEKU_PAG", Name = "Ezernieku pag.", CountyId = 102 },
                new City { Id = 344, Code = "KEPOVAS_PAG", Name = "Ķepovas pag.", CountyId = 102 },
                new City { Id = 345, Code = "SKAUNES_PAG", Name = "Šķaunes pag.", CountyId = 102 },
                new City { Id = 346, Code = "BERZINU_PAG", Name = "Bērziņu pag.", CountyId = 102 },
                new City { Id = 347, Code = "ANDRUPENES_PAG", Name = "Andrupenes pag.", CountyId = 102 },
                new City { Id = 348, Code = "KONSTANTINOVAS_PAG", Name = "Konstantinovas pag.", CountyId = 102 },
                new City { Id = 349, Code = "DAGDAS_PAG", Name = "Dagdas pag.", CountyId = 102 },
                new City { Id = 350, Code = "SVARINU_PAG", Name = "Svariņu pag.", CountyId = 102 },
                new City { Id = 351, Code = "ANDZELU_PAG", Name = "Andzeļu pag.", CountyId = 102 },

                //Daugavpils nov.
                new City { Id = 352, Code = "MEDUMU_PAG", Name = "Medumu pag.", CountyId = 104 },
                new City { Id = 353, Code = "VABOLES_PAG", Name = "Vaboles pag.", CountyId = 104 },
                new City { Id = 354, Code = "KALUPES_PAG", Name = "Kalupes pag.", CountyId = 104 },
                new City { Id = 355, Code = "DUBNAS_PAG", Name = "Dubnas pag.", CountyId = 104 },
                new City { Id = 356, Code = "LIKSNAS_PAG", Name = "Līksnas pag.", CountyId = 104 },
                new City { Id = 357, Code = "BIKERNIEKU_PAG", Name = "Biķernieku pag.", CountyId = 104 },
                new City { Id = 358, Code = "KALKUNES_PAG", Name = "Kalkūnes pag.", CountyId = 104 },
                new City { Id = 359, Code = "MALINOVAS_PAG", Name = "Maļinovas pag.", CountyId = 104 },
                new City { Id = 360, Code = "LAUCESAS_PAG", Name = "Laucesas pag.", CountyId = 104 },
                new City { Id = 361, Code = "NICGALES_PAG", Name = "Nīcgales pag.", CountyId = 104 },
                new City { Id = 362, Code = "DEMENES_PAG", Name = "Demenes pag.", CountyId = 104 },
                new City { Id = 363, Code = "NAUJENES_PAG", Name = "Naujenes pag.", CountyId = 104 },
                new City { Id = 364, Code = "SVENTES_PAG", Name = "Sventes pag.", CountyId = 104 },
                new City { Id = 365, Code = "TABORES_PAG", Name = "Tabores pag.", CountyId = 104 },
                new City { Id = 366, Code = "AMBELU_PAG", Name = "Ambeļu pag.", CountyId = 104 },
                new City { Id = 367, Code = "VISKU_PAG", Name = "Višķu pag.", CountyId = 104 },
                new City { Id = 368, Code = "SKRUDALIENAS_PAG", Name = "Skrudalienas pag.", CountyId = 104 },
                new City { Id = 369, Code = "SALIENAS_PAG", Name = "Salienas pag.", CountyId = 104 },
                new City { Id = 370, Code = "VECSALIENAS_PAG", Name = "Vecsalienas pag.", CountyId = 104 },

                //Dobeles nov.
                new City { Id = 371, Code = "DOBELE", Name = "Dobele", CountyId = 106 },
                new City { Id = 372, Code = "JAUNBERZES_PAG", Name = "Jaunbērzes pag.", CountyId = 106 },
                new City { Id = 373, Code = "PENKULES_PAG", Name = "Penkules pag.", CountyId = 106 },
                new City { Id = 374, Code = "NAUDITES_PAG", Name = "Naudītes pag.", CountyId = 106 },
                new City { Id = 375, Code = "ANNENIEKU_PAG", Name = "Annenieku pag.", CountyId = 106 },
                new City { Id = 376, Code = "BERZES_PAG", Name = "Bērzes pag.", CountyId = 106 },
                new City { Id = 377, Code = "AURU_PAG", Name = "Auru pag.", CountyId = 106 },
                new City { Id = 378, Code = "DOBELES_PAG", Name = "Dobeles pag.", CountyId = 106 },
                new City { Id = 379, Code = "KRIMUNU_PAG", Name = "Krimūnu pag.", CountyId = 106 },
                new City { Id = 380, Code = "BIKSTU_PAG", Name = "Bikstu pag.", CountyId = 106 },
                new City { Id = 381, Code = "ZEBRENES_PAG", Name = "Zebrenes pag.", CountyId = 106 },

                //Dundagas nov.
                new City { Id = 382, Code = "DUNDAGAS_PAG", Name = "Dundagas pag.", CountyId = 108 },
                new City { Id = 383, Code = "KOLKAS_PAG", Name = "Kolkas pag.", CountyId = 108 },
                new City { Id = 384, Code = "DUNDAGA", Name = "Dundaga", CountyId = 108 },

                //Engures nov.
                new City { Id = 385, Code = "ENGURES_PAG", Name = "Engures pag.", CountyId = 110 },
                new City { Id = 386, Code = "LAPMEZCIEMA_PAG", Name = "Lapmežciema pag.", CountyId = 110 },
                new City { Id = 387, Code = "SMARDES_PAG", Name = "Smārdes pag.", CountyId = 110 },
                new City { Id = 388, Code = "PLIENCIEMS", Name = "Plieņciems", CountyId = 110 },
                new City { Id = 389, Code = "ENGURE", Name = "Engure", CountyId = 110 },
                new City { Id = 390, Code = "LAPMEZCIEMS", Name = "Lapmežciems", CountyId = 110 },
                new City { Id = 391, Code = "RAGACIEMS", Name = "Ragaciems", CountyId = 110 },
                new City { Id = 392, Code = "SMARDE", Name = "Smārde", CountyId = 110 },

                //Grobiņas nov.
                new City { Id = 393, Code = "GROBINA", Name = "Grobiņa", CountyId = 112 },
                new City { Id = 394, Code = "BARTAS_PAG", Name = "Bārtas pag.", CountyId = 112 },
                new City { Id = 395, Code = "GROBINAS_PAG", Name = "Grobiņas pag.", CountyId = 112 },
                new City { Id = 396, Code = "GAVIEZES_PAG", Name = "Gaviezes pag.", CountyId = 112 },
                new City { Id = 397, Code = "MEDZES_PAG", Name = "Medzes pag.", CountyId = 112 },
                new City { Id = 398, Code = "SKEDE", Name = "Šķēde", CountyId = 112 },

                //Gulbenes nov.
                new City { Id = 399, Code = "GULBENE", Name = "Gulbene", CountyId = 114 },
                new City { Id = 400, Code = "RANKAS_PAG", Name = "Rankas pag.", CountyId = 114 },
                new City { Id = 401, Code = "DRUVIENAS_PAG", Name = "Druvienas pag.", CountyId = 114 },
                new City { Id = 402, Code = "STAMERIENAS_PAG", Name = "Stāmerienas pag.", CountyId = 114 },
                new City { Id = 403, Code = "LITENES_PAG", Name = "Litenes pag.", CountyId = 114 },
                new City { Id = 404, Code = "LIZUMA_PAG", Name = "Lizuma pag.", CountyId = 114 },
                new City { Id = 405, Code = "JAUNGULBENES_PAG", Name = "Jaungulbenes pag.", CountyId = 114 },
                new City { Id = 406, Code = "STRADU_PAG", Name = "Stradu pag.", CountyId = 114 },
                new City { Id = 407, Code = "GALGAUSKAS_PAG", Name = "Galgauskas pag.", CountyId = 114 },
                new City { Id = 408, Code = "DAUKSTU_PAG", Name = "Daukstu pag.", CountyId = 114 },
                new City { Id = 409, Code = "TIRZAS_PAG", Name = "Tirzas pag.", CountyId = 114 },
                new City { Id = 410, Code = "LIGO_PAG", Name = "Līgo pag.", CountyId = 114 },
                new City { Id = 411, Code = "BELAVAS_PAG", Name = "Beļavas pag.", CountyId = 114 },
                new City { Id = 412, Code = "LEJASCIEMA_PAG", Name = "Lejasciema pag.", CountyId = 114 },

                //Jaunjelgavas nov.
                new City { Id = 413, Code = "JAUNJELGAVA", Name = "Jaunjelgava", CountyId = 116 },
                new City { Id = 414, Code = "JAUNJELGAVAS_PAG", Name = "Jaunjelgavas pag.", CountyId = 116 },
                new City { Id = 415, Code = "SERENES_PAG", Name = "Sērenes pag.", CountyId = 116 },
                new City { Id = 416, Code = "DAUDZESES_PAG", Name = "Daudzeses pag.", CountyId = 116 },
                new City { Id = 417, Code = "SUNAKSTES_PAG", Name = "Sunākstes pag.", CountyId = 116 },
                new City { Id = 418, Code = "SECES_PAG", Name = "Seces pag.", CountyId = 116 },
                new City { Id = 419, Code = "STABURAGA_PAG", Name = "Staburaga pag.", CountyId = 116 },

                //Jaunpils nov.
                new City { Id = 420, Code = "JAUNPILS_PAG", Name = "Jaunpils pag.", CountyId = 118 },
                new City { Id = 421, Code = "VIESATU_PAG", Name = "Viesatu pag.", CountyId = 118 },

                //Jēkabpils nov.
                new City { Id = 422, Code = "LEIMANU_PAG", Name = "Leimaņu pag.", CountyId = 120 },
                new City { Id = 423, Code = "RUBENES_PAG", Name = "Rubenes pag.", CountyId = 120 },
                new City { Id = 424, Code = "DIGNAJAS_PAG", Name = "Dignājas pag.", CountyId = 120 },
                new City { Id = 425, Code = "KALNA_PAG", Name = "Kalna pag.", CountyId = 120 },
                new City { Id = 426, Code = "ZASAS_PAG", Name = "Zasas pag.", CountyId = 120 },
                new City { Id = 427, Code = "ABELU_PAG", Name = "Ābeļu pag.", CountyId = 120 },
                new City { Id = 428, Code = "DUNAVAS_PAG", Name = "Dunavas pag.", CountyId = 120 },

                //Jelgavas nov.
                new City { Id = 429, Code = "GLUDAS_PAG", Name = "Glūdas pag.", CountyId = 122 },
                new City { Id = 430, Code = "LIVBERZES_PAG", Name = "Līvbērzes pag.", CountyId = 122 },
                new City { Id = 431, Code = "SESAVAS_PAG", Name = "Sesavas pag.", CountyId = 122 },
                new City { Id = 432, Code = "VALGUNDES_PAG", Name = "Valgundes pag.", CountyId = 122 },
                new City { Id = 433, Code = "JAUNSVIRLAUKAS_PAG", Name = "Jaunsvirlaukas pag.", CountyId = 122 },
                new City { Id = 434, Code = "SVETES_PAG", Name = "Svētes pag.", CountyId = 122 },
                new City { Id = 435, Code = "KALNCIEMA_PAG", Name = "Kalnciema pag.", CountyId = 122 },
                new City { Id = 436, Code = "LIELPLATONES_PAG", Name = "Lielplatones pag.", CountyId = 122 },
                new City { Id = 437, Code = "PLATONES_PAG", Name = "Platones pag.", CountyId = 122 },
                new City { Id = 438, Code = "VILCES_PAG", Name = "Vilces pag.", CountyId = 122 },
                new City { Id = 439, Code = "ELEJAS_PAG", Name = "Elejas pag.", CountyId = 122 },
                new City { Id = 440, Code = "ZALENIEKU_PAG", Name = "Zaļenieku pag.", CountyId = 122 },
                new City { Id = 441, Code = "VIRCAVAS_PAG", Name = "Vircavas pag.", CountyId = 122 },
                new City { Id = 442, Code = "ELEJA", Name = "Eleja", CountyId = 122 },
                new City { Id = 443, Code = "ATPUTA", Name = "Atpūta", CountyId = 122 },
                new City { Id = 444, Code = "TUSKI", Name = "Tušķi", CountyId = 122 },
                new City { Id = 445, Code = "VITOLINI", Name = "Vītoliņi", CountyId = 122 },

                //Kārsavas nov.
                new City { Id = 446, Code = "KARSAVA", Name = "Kārsava", CountyId = 124 },
                new City { Id = 447, Code = "MERDZENES_PAG", Name = "Mērdzenes pag.", CountyId = 124 },
                new City { Id = 448, Code = "SALNAVAS_PAG", Name = "Salnavas pag.", CountyId = 124 },
                new City { Id = 449, Code = "MEZVIDU_PAG", Name = "Mežvidu pag.", CountyId = 124 },
                new City { Id = 450, Code = "MALNAVAS_PAG", Name = "Malnavas pag.", CountyId = 124 },
                new City { Id = 451, Code = "GOLISEVAS_PAG", Name = "Goliševas pag.", CountyId = 124 },

                //Kokneses nov.
                new City { Id = 452, Code = "BEBRU_PAG", Name = "Bebru pag.", CountyId = 126 },
                new City { Id = 453, Code = "IRSU_PAG", Name = "Iršu pag.", CountyId = 126 },
                new City { Id = 454, Code = "KOKNESES_PAG", Name = "Kokneses pag.", CountyId = 126 },
                new City { Id = 455, Code = "KOKNESE", Name = "Koknese", CountyId = 126 },

                //Krimuldas nov.
                new City { Id = 456, Code = "KRIMULDAS_PAG", Name = "Krimuldas pag.", CountyId = 128 },
                new City { Id = 457, Code = "LEDURGAS_PAG", Name = "Lēdurgas pag.", CountyId = 128 },

                //Krustpils nov.
                new City { Id = 458, Code = "VIPES_PAG", Name = "Vīpes pag.", CountyId = 130 },
                new City { Id = 459, Code = "KUKU_PAG", Name = "Kūku pag.", CountyId = 130 },
                new City { Id = 460, Code = "VARIESU_PAG", Name = "Variešu pag.", CountyId = 130 },
                new City { Id = 461, Code = "MEZARES_PAG", Name = "Mežāres pag.", CountyId = 130 },
                new City { Id = 462, Code = "KRUSTPILS_PAG", Name = "Krustpils pag.", CountyId = 130 },
                new City { Id = 463, Code = "ATASIENES_PAG", Name = "Atašienes pag.", CountyId = 130 },

                //Kuldīgas nov.
                new City { Id = 464, Code = "KULDIGA", Name = "Kuldīga", CountyId = 132 },
                new City { Id = 465, Code = "RUMBAS_PAG", Name = "Rumbas pag.", CountyId = 132 },
                new City { Id = 466, Code = "SNEPELES_PAG", Name = "Snēpeles pag.", CountyId = 132 },
                new City { Id = 467, Code = "GUDENIEKU_PAG", Name = "Gudenieku pag.", CountyId = 132 },
                new City { Id = 468, Code = "EDOLES_PAG", Name = "Ēdoles pag.", CountyId = 132 },
                new City { Id = 469, Code = "LAIDU_PAG", Name = "Laidu pag.", CountyId = 132 },
                new City { Id = 470, Code = "PELCU_PAG", Name = "Pelču pag.", CountyId = 132 },
                new City { Id = 471, Code = "PADURES_PAG", Name = "Padures pag.", CountyId = 132 },
                new City { Id = 472, Code = "KURMALES_PAG", Name = "Kurmāles pag.", CountyId = 132 },
                new City { Id = 473, Code = "VARMES_PAG", Name = "Vārmes pag.", CountyId = 132 },
                new City { Id = 474, Code = "KABILES_PAG", Name = "Kabiles pag.", CountyId = 132 },
                new City { Id = 475, Code = "IVANDES_PAG", Name = "Īvandes pag.", CountyId = 132 },
                new City { Id = 476, Code = "RENDAS_PAG", Name = "Rendas pag.", CountyId = 132 },
                new City { Id = 477, Code = "TURLAVAS_PAG", Name = "Turlavas pag.", CountyId = 132 },

                //Ķekavas nov.
                new City { Id = 478, Code = "BALOZI", Name = "Baloži", CountyId = 134 },
                new City { Id = 479, Code = "VALDLAUCI", Name = "Valdlauči", CountyId = 134 },
                new City { Id = 480, Code = "KEKAVAS_PAG", Name = "Ķekavas pag.", CountyId = 134 },
                new City { Id = 481, Code = "DAUGMALES_PAG", Name = "Daugmales pag.", CountyId = 134 },
                new City { Id = 482, Code = "KEKAVA", Name = "Ķekava", CountyId = 134 },
                new City { Id = 483, Code = "RAMAVA", Name = "Rāmava", CountyId = 134 },
                new City { Id = 484, Code = "KROGSILS", Name = "Krogsils", CountyId = 134 },
                new City { Id = 485, Code = "ODUKALNS", Name = "Odukalns", CountyId = 134 },

                //Līgatnes nov.
                new City { Id = 486, Code = "LIGATNE", Name = "Līgatne", CountyId = 136 },
                new City { Id = 487, Code = "LIGATNES_PAG", Name = "Līgatnes pag.", CountyId = 136 },

                //Limbažu nov.
                new City { Id = 488, Code = "LIMBAZI", Name = "Limbaži", CountyId = 138 },
                new City { Id = 489, Code = "LIMBAZU_PAG", Name = "Limbažu pag.", CountyId = 138 },
                new City { Id = 490, Code = "VIDRIZU_PAG", Name = "Vidrižu pag.", CountyId = 138 },
                new City { Id = 491, Code = "KATVARU_PAG", Name = "Katvaru pag.", CountyId = 138 },
                new City { Id = 492, Code = "UMURGAS_PAG", Name = "Umurgas pag.", CountyId = 138 },
                new City { Id = 493, Code = "SKULTES_PAG", Name = "Skultes pag.", CountyId = 138 },
                new City { Id = 494, Code = "PALES_PAG", Name = "Pāles pag.", CountyId = 138 },
                new City { Id = 495, Code = "VILKENES_PAG", Name = "Viļķenes pag.", CountyId = 138 },
                new City { Id = 496, Code = "ZIEMELBLAZMA", Name = "Ziemeļblāzma", CountyId = 138 },
                new City { Id = 497, Code = "SKULTE_LIMBAZU", Name = "Skulte", CountyId = 138 },

                //Ludzas nov.
                new City { Id = 498, Code = "LUDZA", Name = "Ludza", CountyId = 140 },
                new City { Id = 499, Code = "ISNAUDAS_PAG", Name = "Isnaudas pag.", CountyId = 140 },
                new City { Id = 500, Code = "PILDAS_PAG", Name = "Pildas pag.", CountyId = 140 },
                new City { Id = 501, Code = "NUKSU_PAG", Name = "Ņukšu pag.", CountyId = 140 },
                new City { Id = 502, Code = "BRIGU_PAG", Name = "Briģu pag.", CountyId = 140 },
                new City { Id = 503, Code = "NIRZAS_PAG", Name = "Nirzas pag.", CountyId = 140 },
                new City { Id = 504, Code = "ISTRAS_PAG", Name = "Istras pag.", CountyId = 140 },
                new City { Id = 505, Code = "CIRMAS_PAG", Name = "Cirmas pag.", CountyId = 140 },
                new City { Id = 506, Code = "RUNDENU_PAG", Name = "Rundēnu pag.", CountyId = 140 },
                new City { Id = 507, Code = "PURENU_PAG", Name = "Pureņu pag.", CountyId = 140 },

                //Madonas nov.
                new City { Id = 508, Code = "MADONA", Name = "Madona", CountyId = 142 },
                new City { Id = 509, Code = "BARKAVAS_PAG", Name = "Barkavas pag.", CountyId = 142 },
                new City { Id = 510, Code = "BERZAUNES_PAG", Name = "Bērzaunes pag.", CountyId = 142 },
                new City { Id = 511, Code = "LAUDONAS_PAG", Name = "Ļaudonas pag.", CountyId = 142 },
                new City { Id = 512, Code = "VESTIENAS_PAG", Name = "Vestienas pag.", CountyId = 142 },
                new City { Id = 513, Code = "LIEZERES_PAG", Name = "Liezēres pag.", CountyId = 142 },
                new City { Id = 514, Code = "SARKANU_PAG", Name = "Sarkaņu pag.", CountyId = 142 },
                new City { Id = 515, Code = "KALSNAVAS_PAG", Name = "Kalsnavas pag.", CountyId = 142 },
                new City { Id = 516, Code = "METRIENAS_PAG", Name = "Mētrienas pag.", CountyId = 142 },
                new City { Id = 517, Code = "MARCIENAS_PAG", Name = "Mārcienas pag.", CountyId = 142 },
                new City { Id = 518, Code = "PRAULIENAS_PAG", Name = "Praulienas pag.", CountyId = 142 },
                new City { Id = 519, Code = "LAZDONAS_PAG", Name = "Lazdonas pag.", CountyId = 142 },
                new City { Id = 520, Code = "DZELZAVAS_PAG", Name = "Dzelzavas pag.", CountyId = 142 },
                new City { Id = 521, Code = "OSUPES_PAG", Name = "Ošupes pag.", CountyId = 142 },
                new City { Id = 522, Code = "ARONAS_PAG", Name = "Aronas pag.", CountyId = 142 },
                new City { Id = 523, Code = "BARKAVA", Name = "Barkava", CountyId = 142 },

                //Mālpils nov.
                new City { Id = 524, Code = "SIDGUNDA", Name = "Sidgunda", CountyId = 144 },
                new City { Id = 525, Code = "BUKAS", Name = "Bukas", CountyId = 144 },
                new City { Id = 526, Code = "VITE", Name = "Vite", CountyId = 144 },
                new City { Id = 527, Code = "MALPILS", Name = "Mālpils", CountyId = 144 },
                new City { Id = 528, Code = "UPMALAS", Name = "Upmalas", CountyId = 144 },

                //Mārupes nov.
                new City { Id = 529, Code = "MARUPE", Name = "Mārupe", CountyId = 146 },
                new City { Id = 530, Code = "SKULTE", Name = "Skulte", CountyId = 146 },
                new City { Id = 531, Code = "VETRAS", Name = "Vētras", CountyId = 146 },
                new City { Id = 532, Code = "JAUNMARUPE", Name = "Jaunmārupe", CountyId = 146 },
                new City { Id = 533, Code = "TIRAINE", Name = "Tīraine", CountyId = 146 },
                new City { Id = 534, Code = "LIDOSTA_RIGA", Name = "Lidosta \"Rīga\"", CountyId = 146 },

                //Mazsalacas nov.
                new City { Id = 535, Code = "MAZSALACA", Name = "Mazsalaca", CountyId = 148 },
                new City { Id = 536, Code = "RAMATAS_PAG", Name = "Ramatas pag.", CountyId = 148 },
                new City { Id = 537, Code = "MAZSALACAS_PAG", Name = "Mazsalacas pag.", CountyId = 148 },
                new City { Id = 538, Code = "SKANKALNES_PAG", Name = "Skaņkalnes pag.", CountyId = 148 },
                new City { Id = 539, Code = "SELU_PAG", Name = "Sēļu pag.", CountyId = 148 },

                //Naukšēnu nov.
                new City { Id = 540, Code = "KONU_PAG", Name = "Ķoņu pag.", CountyId = 150 },
                new City { Id = 541, Code = "NAUKSENU_PAG", Name = "Naukšēnu pag.", CountyId = 150 },

                //Neretas nov.
                new City { Id = 542, Code = "NERETAS_PAG", Name = "Neretas pag.", CountyId = 152 },
                new City { Id = 543, Code = "PILSKALNES_NERETAS", Name = "Pilskalnes pag.", CountyId = 152 },
                new City { Id = 544, Code = "ZALVES_PAG", Name = "Zalves pag.", CountyId = 152 },
                new City { Id = 545, Code = "MAZZALVES_PAG", Name = "Mazzalves pag.", CountyId = 152 },
                new City { Id = 546, Code = "NERETA", Name = "Nereta", CountyId = 152 },

                //Nīcas nov.
                new City { Id = 547, Code = "NICAS_PAG", Name = "Nīcas pag.", CountyId = 154 },
                new City { Id = 548, Code = "OTANKU_PAG", Name = "Otaņķu pag.", CountyId = 154 },

                //Olaines nov.
                new City { Id = 549, Code = "OLAINE", Name = "Olaine", CountyId = 156 },
                new City { Id = 550, Code = "OLAINES_PAG", Name = "Olaines pag.", CountyId = 156 },
                new City { Id = 551, Code = "JAUNOLAINE", Name = "Jaunolaine", CountyId = 156 },
                new City { Id = 552, Code = "PAROLAINE", Name = "Pārolaine", CountyId = 156 },
                new City { Id = 553, Code = "STUNISI", Name = "Stūnīši", CountyId = 156 },
                new City { Id = 554, Code = "GRENES", Name = "Grēnes", CountyId = 156 },

                //Pārgaujas nov.
                new City { Id = 555, Code = "STALBES_PAG", Name = "Stalbes pag.", CountyId = 158 },
                new City { Id = 556, Code = "RAISKUMA_PAG", Name = "Raiskuma pag.", CountyId = 158 },
                new City { Id = 557, Code = "STRAUPES_PAG", Name = "Straupes pag.", CountyId = 158 },

                //Pāvilostas nov.
                new City { Id = 558, Code = "PAVILOSTA", Name = "Pāvilosta", CountyId = 160 },
                new City { Id = 559, Code = "SAKAS_PAG", Name = "Sakas pag.", CountyId = 160 },
                new City { Id = 560, Code = "VERGALES_PAG", Name = "Vērgales pag.", CountyId = 160 },

                //Pļaviņu nov.
                new City { Id = 561, Code = "PLAVINAS", Name = "Pļaviņas", CountyId = 162 },
                new City { Id = 562, Code = "KLINTAINES_PAG", Name = "Klintaines pag.", CountyId = 162 },
                new City { Id = 563, Code = "VIETALVAS_PAG", Name = "Vietalvas pag.", CountyId = 162 },
                new City { Id = 564, Code = "AIVIEKSTES_PAG", Name = "Aiviekstes pag.", CountyId = 162 },

                //Priekules nov.
                new City { Id = 565, Code = "PRIEKULE", Name = "Priekule", CountyId = 164 },
                new City { Id = 566, Code = "VIRGAS_PAG", Name = "Virgas pag.", CountyId = 164 },
                new City { Id = 567, Code = "KALETU_PAG", Name = "Kalētu pag.", CountyId = 164 },
                new City { Id = 568, Code = "PRIEKULES_PAG", Name = "Priekules pag.", CountyId = 164 },
                new City { Id = 569, Code = "BUNKAS_PAG", Name = "Bunkas pag.", CountyId = 164 },
                new City { Id = 570, Code = "GRAMZDAS_PAG", Name = "Gramzdas pag.", CountyId = 164 },

                //Priekuļu nov.
                new City { Id = 571, Code = "LIEPAS_PAG", Name = "Liepas pag.", CountyId = 166 },
                new City { Id = 572, Code = "VESELAVAS_PAG", Name = "Veselavas pag.", CountyId = 166 },
                new City { Id = 573, Code = "PRIEKULU_PAG", Name = "Priekuļu pag.", CountyId = 166 },
                new City { Id = 574, Code = "MARSNENU_PAG", Name = "Mārsnēnu pag.", CountyId = 166 },
                new City { Id = 575, Code = "PRIEKUĻI", Name = "Priekuļi", CountyId = 166 },

                //Rēzeknes nov.
                new City { Id = 576, Code = "GAIGALAVAS_PAG", Name = "Gaigalavas pag.", CountyId = 168 },
                new City { Id = 577, Code = "OZOLMUIZAS_PAG", Name = "Ozolmuižas pag.", CountyId = 168 },
                new City { Id = 578, Code = "RIKAVAS_PAG", Name = "Rikavas pag.", CountyId = 168 },
                new City { Id = 579, Code = "AUDRINU_PAG", Name = "Audriņu pag.", CountyId = 168 },
                new City { Id = 580, Code = "OZOLAINES_PAG", Name = "Ozolaines pag.", CountyId = 168 },
                new City { Id = 581, Code = "FEIMANU_PAG", Name = "Feimaņu pag.", CountyId = 168 },
                new City { Id = 582, Code = "DRICANU_PAG", Name = "Dricānu pag.", CountyId = 168 },
                new City { Id = 583, Code = "PUSAS_PAG", Name = "Pušas pag.", CountyId = 168 },
                new City { Id = 584, Code = "CORNAJAS_PAG", Name = "Čornajas pag.", CountyId = 168 },
                new City { Id = 585, Code = "GRISKANU_PAG", Name = "Griškānu pag.", CountyId = 168 },
                new City { Id = 586, Code = "KAUNATAS_PAG", Name = "Kaunatas pag.", CountyId = 168 },
                new City { Id = 587, Code = "NAGLU_PAG", Name = "Nagļu pag.", CountyId = 168 },
                new City { Id = 588, Code = "SAKSTAGALA_PAG", Name = "Sakstagala pag.", CountyId = 168 },
                new City { Id = 589, Code = "STOLEROVAS_PAG", Name = "Stoļerovas pag.", CountyId = 168 },
                new City { Id = 590, Code = "LUZNAVAS_PAG", Name = "Lūznavas pag.", CountyId = 168 },
                new City { Id = 591, Code = "MAKONKALNA_PAG", Name = "Mākoņkalna pag.", CountyId = 168 },
                new City { Id = 592, Code = "STRUZANU_PAG", Name = "Stružānu pag.", CountyId = 168 },
                new City { Id = 593, Code = "MALTAS_PAG", Name = "Maltas pag.", CountyId = 168 },
                new City { Id = 594, Code = "NAUTRENU_PAG", Name = "Nautrēnu pag.", CountyId = 168 },
                new City { Id = 595, Code = "LENDZU_PAG", Name = "Lendžu pag.", CountyId = 168 },
                new City { Id = 596, Code = "BERZGALES_PAG", Name = "Bērzgales pag.", CountyId = 168 },
                new City { Id = 597, Code = "SILMALAS_PAG", Name = "Silmalas pag.", CountyId = 168 },
                new City { Id = 598, Code = "VEREMU_PAG", Name = "Vērēmu pag.", CountyId = 168 },
                new City { Id = 599, Code = "KANTINIEKU_PAG", Name = "Kantinieku pag.", CountyId = 168 },
                new City { Id = 600, Code = "ILZESKALNA_PAG", Name = "Ilzeskalna pag.", CountyId = 168 },
                new City { Id = 601, Code = "MALTA", Name = "Malta", CountyId = 168 },

                //Rucavas nov.
                new City { Id = 602, Code = "RUCAVAS_PAG", Name = "Rucavas pag.", CountyId = 170 },
                new City { Id = 603, Code = "DUNIKAS_PAG", Name = "Dunikas pag.", CountyId = 170 },
                new City { Id = 604, Code = "JECI", Name = "Ječi", CountyId = 170 },

                //Rugāju nov.
                new City { Id = 605, Code = "RUGAJU_PAG", Name = "Rugāju pag.", CountyId = 172 },
                new City { Id = 606, Code = "LAZDUKALNA_PAG", Name = "Lazdukalna pag.", CountyId = 172 },

                //Rundāles nov.
                new City { Id = 607, Code = "SVITENES_PAG", Name = "Svitenes pag.", CountyId = 174 },
                new City { Id = 608, Code = "RUNDALES_PAG", Name = "Rundāles pag.", CountyId = 174 },
                new City { Id = 609, Code = "VIESTURU_PAG", Name = "Viesturu pag.", CountyId = 174 },

                //Rūjienas nov.
                new City { Id = 610, Code = "RUJIENA", Name = "Rūjiena", CountyId = 176 },
                new City { Id = 611, Code = "IPIKU_PAG", Name = "Ipiķu pag.", CountyId = 176 },
                new City { Id = 612, Code = "VILPULKAS_PAG", Name = "Vilpulkas pag.", CountyId = 176 },
                new City { Id = 613, Code = "LODES_PAG", Name = "Lodes pag.", CountyId = 176 },
                new City { Id = 614, Code = "JERU_PAG", Name = "Jeru pag.", CountyId = 176 },

                //Salacgrīvas nov.
                new City { Id = 615, Code = "AINAZI", Name = "Ainaži", CountyId = 178 },
                new City { Id = 616, Code = "SALACGRIVA", Name = "Salacgrīva", CountyId = 178 },
                new City { Id = 617, Code = "LIEPUPES_PAG", Name = "Liepupes pag.", CountyId = 178 },
                new City { Id = 618, Code = "AINAZU_PAG", Name = "Ainažu pag.", CountyId = 178 },
                new City { Id = 619, Code = "SALACGRIVAS_PAG", Name = "Salacgrīvas pag.", CountyId = 178 },
                new City { Id = 620, Code = "TUJA", Name = "Tūja", CountyId = 178 },
                new City { Id = 621, Code = "LANI", Name = "Lāņi", CountyId = 178 },

                //Salas nov.
                new City { Id = 622, Code = "SELPILS_PAG", Name = "Sēlpils pag.", CountyId = 180 },
                new City { Id = 623, Code = "SALAS_SALAS", Name = "Salas pag.", CountyId = 180 },

                //Saldus nov.
                new City { Id = 624, Code = "SALDUS", Name = "Saldus", CountyId = 182 },
                new City { Id = 625, Code = "RUBAS_PAG", Name = "Rubas pag.", CountyId = 182 },
                new City { Id = 626, Code = "SKEDES_PAG", Name = "Šķēdes pag.", CountyId = 182 },
                new City { Id = 627, Code = "JAUNAUCES_PAG", Name = "Jaunauces pag.", CountyId = 182 },
                new City { Id = 628, Code = "NIGRANDES_PAG", Name = "Nīgrandes pag.", CountyId = 182 },
                new City { Id = 629, Code = "ZANAS_PAG", Name = "Zaņas pag.", CountyId = 182 },
                new City { Id = 630, Code = "ZIRNU_PAG", Name = "Zirņu pag.", CountyId = 182 },
                new City { Id = 631, Code = "JAUNLUTRINU_PAG", Name = "Jaunlutriņu pag.", CountyId = 182 },
                new City { Id = 632, Code = "PAMPALU_PAG", Name = "Pampāļu pag.", CountyId = 182 },
                new City { Id = 633, Code = "VADAKSTES_PAG", Name = "Vadakstes pag.", CountyId = 182 },
                new City { Id = 634, Code = "ZVARDES_PAG", Name = "Zvārdes pag.", CountyId = 182 },
                new City { Id = 635, Code = "KURSISU_PAG", Name = "Kursīšu pag.", CountyId = 182 },
                new City { Id = 636, Code = "SALDUS_PAG", Name = "Saldus pag.", CountyId = 182 },
                new City { Id = 637, Code = "EZERES_PAG", Name = "Ezeres pag.", CountyId = 182 },
                new City { Id = 638, Code = "NOVADNIEKU_PAG", Name = "Novadnieku pag.", CountyId = 182 },
                new City { Id = 639, Code = "LUTRINU_PAG", Name = "Lutriņu pag.", CountyId = 182 },

                //Skrīveru nov.
                new City { Id = 640, Code = "SKRIVERI", Name = "Skrīveri", CountyId = 184 },
                new City { Id = 641, Code = "ZIEDUGRAVAS", Name = "Ziedugravas", CountyId = 184 },
                new City { Id = 642, Code = "ZEMKOPIBAS_INSTITUTS", Name = "Zemkopības institūts", CountyId = 184 },
                new City { Id = 643, Code = "KLIDZINA", Name = "Klidziņa", CountyId = 184 },
                new City { Id = 644, Code = "LICI", Name = "Līči", CountyId = 184 },

                //Skrundas nov.
                new City { Id = 645, Code = "SKRUNDA", Name = "Skrunda", CountyId = 186 },
                new City { Id = 646, Code = "RANKU_PAG", Name = "Raņķu pag.", CountyId = 186 },
                new City { Id = 647, Code = "NIKRACES_PAG", Name = "Nīkrāces pag.", CountyId = 186 },
                new City { Id = 648, Code = "RUDBARZU_PAG", Name = "Rudbāržu pag.", CountyId = 186 },
                new City { Id = 649, Code = "SKRUNDAS_PAG", Name = "Skrundas pag.", CountyId = 186 },

                //Smiltenes nov.
                new City { Id = 650, Code = "SMILTENE", Name = "Smiltene", CountyId = 188 },
                new City { Id = 651, Code = "BLOMES_PAG", Name = "Blomes pag.", CountyId = 188 },
                new City { Id = 652, Code = "PALSMANES_PAG", Name = "Palsmanes pag.", CountyId = 188 },
                new City { Id = 653, Code = "BILSKAS_PAG", Name = "Bilskas pag.", CountyId = 188 },
                new City { Id = 654, Code = "LAUNKALNES_PAG", Name = "Launkalnes pag.", CountyId = 188 },
                new City { Id = 655, Code = "SMILTENES_PAG", Name = "Smiltenes pag.", CountyId = 188 },
                new City { Id = 656, Code = "VARINU_PAG", Name = "Variņu pag.", CountyId = 188 },
                new City { Id = 657, Code = "GRUNDZALES_PAG", Name = "Grundzāles pag.", CountyId = 188 },
                new City { Id = 658, Code = "BRANTU_PAG", Name = "Brantu pag.", CountyId = 188 },

                //Strenču nov.
                new City { Id = 659, Code = "SEDA", Name = "Seda", CountyId = 190 },
                new City { Id = 660, Code = "STENCI", Name = "Strenči", CountyId = 190 },
                new City { Id = 661, Code = "PLANU_PAG", Name = "Plāņu pag.", CountyId = 190 },
                new City { Id = 662, Code = "JERCENU_PAG", Name = "Jērcēnu pag.", CountyId = 190 },

                //Talsu nov.
                new City { Id = 663, Code = "STENDE", Name = "Stende", CountyId = 192 },
                new City { Id = 664, Code = "SABILE", Name = "Sabile", CountyId = 192 },
                new City { Id = 665, Code = "TALSI", Name = "Talsi", CountyId = 192 },
                new City { Id = 666, Code = "VALDEMARPILS", Name = "Valdemārpils", CountyId = 192 },
                new City { Id = 667, Code = "LAIDZES_PAG", Name = "Laidzes pag.", CountyId = 192 },
                new City { Id = 668, Code = "VALDGALES_PAG", Name = "Valdgales pag.", CountyId = 192 },
                new City { Id = 669, Code = "ARLAVAS_PAG", Name = "Ārlavas pag.", CountyId = 192 },
                new City { Id = 670, Code = "GIBULU_PAG", Name = "Ģibuļu pag.", CountyId = 192 },
                new City { Id = 671, Code = "IVES_PAG", Name = "Īves pag.", CountyId = 192 },
                new City { Id = 672, Code = "LUBES_PAG", Name = "Lubes pag.", CountyId = 192 },
                new City { Id = 673, Code = "STRAZDES_PAG", Name = "Strazdes pag.", CountyId = 192 },
                new City { Id = 674, Code = "VIRBU_PAG", Name = "Virbu pag.", CountyId = 192 },
                new City { Id = 675, Code = "BALGALES_PAG", Name = "Balgales pag.", CountyId = 192 },
                new City { Id = 676, Code = "KULCIEMA_PAG", Name = "Ķūļciema pag.", CountyId = 192 },
                new City { Id = 677, Code = "LIBAGU_PAG", Name = "Lībagu pag.", CountyId = 192 },
                new City { Id = 678, Code = "LAUCIENAS_PAG", Name = "Laucienes pag.", CountyId = 192 },
                new City { Id = 679, Code = "VANDZENES_PAG", Name = "Vandzenes pag.", CountyId = 192 },
                new City { Id = 680, Code = "ABAVAS_PAG", Name = "Abavas pag.", CountyId = 192 },

                //Tukuma nov.
                new City { Id = 681, Code = "TUKUMS", Name = "Tukums", CountyId = 194 },
                new City { Id = 682, Code = "DZUKSTES_PAG", Name = "Džūkstes pag.", CountyId = 194 },
                new City { Id = 683, Code = "JAUNSATU_PAG", Name = "Jaunsātu pag.", CountyId = 194 },
                new City { Id = 684, Code = "LESTENES_PAG", Name = "Lestenes pag.", CountyId = 194 },
                new City { Id = 685, Code = "SEMES_PAG", Name = "Sēmes pag.", CountyId = 194 },
                new City { Id = 686, Code = "TUMES_PAG", Name = "Tumes pag.", CountyId = 194 },
                new City { Id = 687, Code = "SLAMPES_PAG", Name = "Slampes pag.", CountyId = 194 },
                new City { Id = 688, Code = "IRLAVAS_PAG", Name = "Irlavas pag.", CountyId = 194 },
                new City { Id = 689, Code = "PURES_PAG", Name = "Pūres pag.", CountyId = 194 },
                new City { Id = 690, Code = "DEGOLES_PAG", Name = "Degoles pag.", CountyId = 194 },
                new City { Id = 691, Code = "ZENTENES_PAG", Name = "Zentenes pag.", CountyId = 194 },

                //Vaiņodes nov.
                new City { Id = 692, Code = "EMBUTES_PAG", Name = "Embūtes pag.", CountyId = 196 },
                new City { Id = 693, Code = "VAINODES_PAG", Name = "Vaiņodes pag.", CountyId = 196 },
                new City { Id = 694, Code = "VAINODE", Name = "Vaiņode", CountyId = 196 },

                //Valkas nov.
                new City { Id = 695, Code = "VALKA", Name = "Valka", CountyId = 198 },
                new City { Id = 696, Code = "KARKU_PAG", Name = "Kārķu pag.", CountyId = 198 },
                new City { Id = 697, Code = "VALKAS_PAG", Name = "Valkas pag.", CountyId = 198 },
                new City { Id = 698, Code = "VIJCIEMA_PAG", Name = "Vijciema pag.", CountyId = 198 },
                new City { Id = 699, Code = "ZVARTAVAS_PAG", Name = "Zvārtavas pag.", CountyId = 198 },
                new City { Id = 700, Code = "ERGEMES_PAG", Name = "Ērģemes pag.", CountyId = 198 },

                //Kocēnu nov.
                new City { Id = 701, Code = "DIKLU_PAG", Name = "Dikļu pag.", CountyId = 200 },
                new City { Id = 702, Code = "KOCENU_PAG", Name = "Kocēnu pag.", CountyId = 200 },
                new City { Id = 703, Code = "ZILAKALNA_PAG", Name = "Zilākalna pag.", CountyId = 200 },
                new City { Id = 704, Code = "BERZAINES_PAG", Name = "Bērzaines pag.", CountyId = 200 },
                new City { Id = 705, Code = "VAIDAVAS_PAG", Name = "Vaidavas pag.", CountyId = 200 },
                new City { Id = 706, Code = "KOCENI", Name = "Kocēni", CountyId = 200 },

                //Varakļānu nov.
                new City { Id = 707, Code = "VARAKLANI", Name = "Varakļāni", CountyId = 202 },
                new City { Id = 708, Code = "VARAKLANU_PAG", Name = "Varakļānu pag.", CountyId = 202 },
                new City { Id = 709, Code = "MURMASTIENES_PAG", Name = "Murmastienes pag.", CountyId = 202 },

                //Vecpiebalgas nov.
                new City { Id = 710, Code = "INESU_PAG", Name = "Inešu pag.", CountyId = 204 },
                new City { Id = 711, Code = "TAURENES_PAG", Name = "Taurenes pag.", CountyId = 204 },
                new City { Id = 712, Code = "DZERBENES_PAG", Name = "Dzērbenes pag.", CountyId = 204 },
                new City { Id = 713, Code = "KAIVES_PAG", Name = "Kaives pag.", CountyId = 204 },
                new City { Id = 714, Code = "VECPIEBALGAS_PAG", Name = "Vecpiebalgas pag.", CountyId = 204 },
                new City { Id = 715, Code = "VECPIEBALGA", Name = "Vecpiebalga", CountyId = 204 },

                //Vecumnieku nov.
                new City { Id = 716, Code = "STELPES_PAG", Name = "Stelpes pag.", CountyId = 206 },
                new City { Id = 717, Code = "BARBELES_PAG", Name = "Bārbeles pag.", CountyId = 206 },
                new City { Id = 718, Code = "KURMENES_PAG", Name = "Kurmenes pag.", CountyId = 206 },
                new City { Id = 719, Code = "SKAISTKALNES_PAG", Name = "Skaistkalnes pag.", CountyId = 206 },
                new City { Id = 720, Code = "VECUMNIEKU_PAG", Name = "Vecumnieku pag.", CountyId = 206 },
                new City { Id = 721, Code = "VALLES_PAG", Name = "Valles pag.", CountyId = 206 },
                new City { Id = 722, Code = "SKAISTKALNE", Name = "Skaistkalne", CountyId = 206 },
                new City { Id = 723, Code = "VECUMNIEKI", Name = "Vecumnieki", CountyId = 206 },

                //Ventspils nov.
                new City { Id = 724, Code = "PILTENE", Name = "Piltene", CountyId = 208 },
                new City { Id = 725, Code = "PUZES_PAG", Name = "Puzes pag.", CountyId = 208 },
                new City { Id = 726, Code = "PILTENES_PAG", Name = "Piltenes pag.", CountyId = 208 },
                new City { Id = 727, Code = "USMAS_PAG", Name = "Usmas pag.", CountyId = 208 },
                new City { Id = 728, Code = "ZIRU_PAG", Name = "Ziru pag.", CountyId = 208 },
                new City { Id = 729, Code = "ANCES_PAG", Name = "Ances pag.", CountyId = 208 },
                new City { Id = 730, Code = "JURKALNES_PAG", Name = "Jūrkalnes pag.", CountyId = 208 },
                new City { Id = 731, Code = "UZAVAS_PAG", Name = "Užavas pag.", CountyId = 208 },
                new City { Id = 732, Code = "UGALES_PAG", Name = "Ugāles pag.", CountyId = 208 },
                new City { Id = 733, Code = "POPES_PAG", Name = "Popes pag.", CountyId = 208 },
                new City { Id = 734, Code = "ZLEKU_PAG", Name = "Zlēku pag.", CountyId = 208 },
                new City { Id = 735, Code = "TARGALES_PAG", Name = "Tārgales pag.", CountyId = 208 },
                new City { Id = 736, Code = "VARVES_PAG", Name = "Vārves pag.", CountyId = 208 },

                //Viesītes nov.
                new City { Id = 737, Code = "VIESITE", Name = "Viesīte", CountyId = 210 },
                new City { Id = 738, Code = "SAUKAS_PAG", Name = "Saukas pag.", CountyId = 210 },
                new City { Id = 739, Code = "RITES_PAG", Name = "Rites pag.", CountyId = 210 },
                new City { Id = 740, Code = "VIESITES_PAG", Name = "Viesītes pag.", CountyId = 210 },
                new City { Id = 741, Code = "ELKSNU_PAG", Name = "Elkšņu pag.", CountyId = 210 },

                //Viļakas nov.
                new City { Id = 742, Code = "VILAKA", Name = "Viļaka", CountyId = 212 },
                new City { Id = 743, Code = "KUPRAVAS_PAG", Name = "Kupravas pag.", CountyId = 212 },
                new City { Id = 744, Code = "VECUMU_PAG", Name = "Vecumu pag.", CountyId = 212 },
                new City { Id = 745, Code = "SUSAJU_PAG", Name = "Susāju pag.", CountyId = 212 },
                new City { Id = 746, Code = "ZIGURU_PAG", Name = "Žīguru pag.", CountyId = 212 },
                new City { Id = 747, Code = "MEDNEVAS_PAG", Name = "Medņevas pag.", CountyId = 212 },
                new City { Id = 748, Code = "SKILBENU_PAG", Name = "Šķilbēnu pag.", CountyId = 212 },

                //Viļānu nov.
                new City { Id = 749, Code = "VILANI", Name = "Viļāni", CountyId = 214 },
                new City { Id = 750, Code = "SOKOLKU_PAG", Name = "Sokolku pag.", CountyId = 214 },
                new City { Id = 751, Code = "DEKSARES_PAG", Name = "Dekšāres pag.", CountyId = 214 },
                new City { Id = 752, Code = "VILANU_PAG", Name = "Viļānu pag.", CountyId = 214 },

                //Burtnieku nov.
                new City { Id = 753, Code = "VECATES_PAG", Name = "Vecates pag.", CountyId = 216 },
                new City { Id = 754, Code = "BURTNIEKU_PAG", Name = "Burtnieku pag.", CountyId = 216 },
                new City { Id = 755, Code = "RENCENU_PAG", Name = "Rencēnu pag.", CountyId = 216 },
                new City { Id = 756, Code = "VALMIERAS_PAG", Name = "Valmieras pag.", CountyId = 216 },
                new City { Id = 757, Code = "EVELES_PAG", Name = "Ēveles pag.", CountyId = 216 },
                new City { Id = 758, Code = "MATISU_PAG", Name = "Matīšu pag.", CountyId = 216 },
                new City { Id = 759, Code = "VALMIERMUIŽA", Name = "Valmiermuiža", CountyId = 216 },

                //Ērgļu nov.
                new City { Id = 760, Code = "JUMURDAS_PAG", Name = "Jumurdas pag.", CountyId = 218 },
                new City { Id = 761, Code = "SAUSNEJAS_PAG", Name = "Sausnējas pag.", CountyId = 218 },
                new City { Id = 762, Code = "ERGLU_PAG", Name = "Ērgļu pag.", CountyId = 218 },
                new City { Id = 763, Code = "ERGLI", Name = "Ērgļi", CountyId = 218 },

                //Sējas nov.
                new City { Id = 764, Code = "PABAZI", Name = "Pabaži", CountyId = 220 },
                new City { Id = 765, Code = "ABELITE", Name = "Ābelīte", CountyId = 220 },
                new City { Id = 766, Code = "VAIVARINI", Name = "Vaivariņi", CountyId = 220 },
                new City { Id = 767, Code = "GARSMUIZA", Name = "Gāršmuiža", CountyId = 220 },
                new City { Id = 768, Code = "JAUNKRIMULDA", Name = "Jaunkrimulda", CountyId = 220 },
                new City { Id = 769, Code = "SEJA", Name = "Sēja", CountyId = 220 },
                new City { Id = 770, Code = "MURJANI", Name = "Murjāņi", CountyId = 220 },
                new City { Id = 771, Code = "LOJA", Name = "Loja", CountyId = 220 },

                //Inčukalna nov.
                new City { Id = 772, Code = "VANGAZI", Name = "Vangaži", CountyId = 222 },
                new City { Id = 773, Code = "INCUKALNA_PAG", Name = "Inčukalna pag.", CountyId = 222 },
                new City { Id = 774, Code = "INCUKALNS", Name = "Inčukalns", CountyId = 222 },
                new City { Id = 775, Code = "EGLUPE", Name = "Egļupe", CountyId = 222 },

                //Jaunpiebalgas nov.
                new City { Id = 776, Code = "JAUNPIEBALGAS_PAG", Name = "Jaunpiebalgas pag.", CountyId = 224 },
                new City { Id = 777, Code = "ZOSENU_PAG", Name = "Zosēnu pag.", CountyId = 224 },

                //Saulkrastu nov.
                new City { Id = 778, Code = "SAULKRASTI", Name = "Saulkrasti", CountyId = 226 },
                new City { Id = 779, Code = "SAULKRASTU_PAG", Name = "Saulkrastu pag.", CountyId = 226 },
                new City { Id = 780, Code = "ZVEJNIEKCIEMS", Name = "Zvejniekciems", CountyId = 226 },

                //Raunas nov.
                new City { Id = 781, Code = "DRUSTU_PAG", Name = "Drustu pag.", CountyId = 228 },
                new City { Id = 782, Code = "RAUNAS_PAG", Name = "Raunas pag.", CountyId = 228 },
                new City { Id = 783, Code = "RAUNA", Name = "Rauna", CountyId = 228 },

                //Lielvārdes nov.
                new City { Id = 784, Code = "LIELVARDE", Name = "Lielvārde", CountyId = 230 },
                new City { Id = 785, Code = "JUMPRAVAS_PAG", Name = "Jumpravas pag.", CountyId = 230 },
                new City { Id = 786, Code = "LIELVARDES_PAG", Name = "Lielvārdes pag.", CountyId = 230 },
                new City { Id = 787, Code = "LEDMANES_PAG", Name = "Lēdmanes pag.", CountyId = 230 },

                //Ropažu nov.
                new City { Id = 788, Code = "ROPAZI", Name = "Ropaži", CountyId = 232 },
                new City { Id = 789, Code = "ZAKUMUIZA", Name = "Zaķumuiža", CountyId = 232 },
                new City { Id = 790, Code = "LIELKANGARI", Name = "Lielkangari", CountyId = 232 },
                new City { Id = 791, Code = "SILAKROGS", Name = "Silakrogs", CountyId = 232 },
                new City { Id = 792, Code = "TUMSUPE", Name = "Tumšupe", CountyId = 232 },
                new City { Id = 793, Code = "AUGSCIEMS", Name = "Augšciems", CountyId = 232 },
                new City { Id = 794, Code = "BAJARI", Name = "Bajāri", CountyId = 232 },
                new City { Id = 795, Code = "VAVERKROGS", Name = "Vāverkrogs", CountyId = 232 },
                new City { Id = 796, Code = "VILLASMUIZA", Name = "Villasmuiža", CountyId = 232 },
                new City { Id = 797, Code = "KAKCIEMS", Name = "Kākciems", CountyId = 232 },
                new City { Id = 798, Code = "GAIDAS", Name = "Gaidas", CountyId = 232 },
                new City { Id = 799, Code = "ULUPJI", Name = "Ūlupji", CountyId = 232 },
                new City { Id = 800, Code = "NAGELMUIZA", Name = "Nāgelmuiža", CountyId = 232 },
                new City { Id = 801, Code = "PODKAJAS", Name = "Podkājas", CountyId = 232 },
                new City { Id = 802, Code = "MUCENIEKI", Name = "Mucenieki", CountyId = 232 },
                new City { Id = 803, Code = "ROTKALI", Name = "Rotkaļi", CountyId = 232 },
                new City { Id = 804, Code = "JAUNBAGUMI", Name = "Jaunbagumi", CountyId = 232 },
                new City { Id = 805, Code = "JAUNMUCENIEKI", Name = "Jaunmucenieki", CountyId = 232 },
                new City { Id = 806, Code = "KANGARI", Name = "Kangari", CountyId = 232 },
                new City { Id = 807, Code = "BAJARKROGS", Name = "Bajārkrogs", CountyId = 232 },

                //Riebiņu nov.
                new City { Id = 808, Code = "SILAJANU_PAG", Name = "Silajāņu pag.", CountyId = 234 },
                new City { Id = 809, Code = "GALENU_PAG", Name = "Galēnu pag.", CountyId = 234 },
                new City { Id = 810, Code = "SILUKALNA_PAG", Name = "Sīļukalna pag.", CountyId = 234 },
                new City { Id = 811, Code = "STABULNIEKU_PAG", Name = "Stabulnieku pag.", CountyId = 234 },
                new City { Id = 812, Code = "RIEBINU_PAG", Name = "Riebiņu pag.", CountyId = 234 },
                new City { Id = 813, Code = "RUSONAS_PAG", Name = "Rušonas pag.", CountyId = 234 },

                //Stopiņu nov.
                new City { Id = 814, Code = "ULBROKA", Name = "Ulbroka", CountyId = 236 },
                new City { Id = 815, Code = "LICI", Name = "Līči", CountyId = 236 },
                new City { Id = 816, Code = "SAULISU_CIEMS", Name = "Saulīšu ciems", CountyId = 236 },
                new City { Id = 817, Code = "SAURIESI", Name = "Saurieši", CountyId = 236 },
                new City { Id = 818, Code = "CEKULE", Name = "Cekule", CountyId = 236 },
                new City { Id = 819, Code = "UPESLEJAS", Name = "Upeslejas", CountyId = 236 },
                new City { Id = 820, Code = "VALODZES", Name = "Vālodzes", CountyId = 236 },
                new City { Id = 821, Code = "DZIDRINAS", Name = "Dzidriņas", CountyId = 236 },
                new City { Id = 822, Code = "STOPINU_PAG", Name = "Stopiņu pag.", CountyId = 236 },

                //Salaspils nov.
                new City { Id = 823, Code = "SALASPILS", Name = "Salaspils", CountyId = 238 },
                new City { Id = 824, Code = "SALASPILS_PAG", Name = "Salaspils pag.", CountyId = 238 }
            );
        }
    }
}
