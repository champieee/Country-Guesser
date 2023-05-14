using System;
using System.Threading;
using System.Collections.Generic;
using System.Collections;
using System.Collections;
using static System.Net.WebRequestMethods;

class Country {

public Country(){

}

Dictionary<int, Array> countries = new Dictionary<int, Array>();
Dictionary<int, HashSet<string>> myDict = new Dictionary<int, HashSet<string>>();

    public void fillCountries(){

        myDict[0] = new HashSet<string>() { "China", "https://www.burningcompass.com/countries/china/maps/china-outline-map.jpg" };
        myDict[1] = new HashSet<string>() { "United States of America", "https://media.istockphoto.com/id/835357658/vector/usa-map.jpg?s=612x612&w=0&k=20&c=2NWn9P2Zdcfn73WIESjUvoc0rWJaDVP24ZhT6hkcBzw=" };
        myDict[2] = new HashSet<string>() { "Japan", "https://vemaps.com/uploads/img/big/jp-01.jpg" };
        myDict[3] = new HashSet<string>() { "India","https://i.pinimg.com/originals/bd/2e/f2/bd2ef2e7731cbe495481254cb1779262.gif"};
        myDict[4] = new HashSet<string>() { "United Kingdom","https://static.vecteezy.com/system/resources/previews/003/668/496/original/doodle-freehand-drawing-of-the-great-britain-map-free-vector.jpg" };
        myDict[5] = new HashSet<string>() { "Germany","https://static.vecteezy.com/system/resources/previews/008/726/852/non_2x/map-of-germany-outline-map-illustration-free-vector.jpg"};
        myDict[6] = new HashSet<string>() { "France", "https://static.vecteezy.com/system/resources/previews/008/726/860/original/map-of-france-outline-map-illustration-free-vector.jpg"};
        myDict[7] = new HashSet<string>() { "Italy","https://static.vecteezy.com/system/resources/previews/000/639/867/original/italy-and-islands-map-vector.jpg"};
        myDict[8] = new HashSet<string>() { "South Korea", "https://thumbs.dreamstime.com/b/map-south-korea-outline-silhouette-vector-illustration-137914418.jpg"};
        myDict[9] = new HashSet<string>() { "Spain", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR7tCAFnCroRX313HZWhy-b7DXdbVy8UQjAZSzQDb3M&s"};
        myDict[10] = new HashSet<string>() { "Russia","https://i.pinimg.com/originals/cd/e9/60/cde960ea5a762530e31c4d6404f63391.gif"};
        myDict[11] = new HashSet<string>() { "Mexico","https://static.vecteezy.com/system/resources/previews/003/087/792/original/outline-simple-map-of-mexico-free-vector.jpg"};
        myDict[12] = new HashSet<string>() { "Indonesia", "https://thumbs.dreamstime.com/b/indonesia-outline-map-vector-illustration-indonesia-outline-map-vector-illustration-isolated-white-background-125595251.jpg"};
        myDict[13] = new HashSet<string>() { "Turkey", "https://www.burningcompass.com/countries/turkey/maps/turkey-outline-map.jpg"};
        myDict[14] = new HashSet<string>() { "Netherlands", "https://i.pinimg.com/originals/06/45/28/064528dd7ca38092d14da09d1e6752d9.gif"};
        myDict[15] = new HashSet<string>() { "Saudi Arabia", "https://ecdn.teacherspayteachers.com/thumbitem/Saudi-Arabia-Country-Map-Black-White-Solid-Outline-Maps-JPG-SVG-PNG-PDF-EPS-AI-6435143-1610340243/original-6435143-3.jpg"};
        myDict[16] = new HashSet<string>() { "Switzerland", "https://www.freeworldmaps.net/europe/switzerland/switzerland-outline-map.jpg"};
        myDict[17] = new HashSet<string>() { "Poland", "https://t4.ftcdn.net/jpg/00/79/57/81/360_F_79578155_Di0cqM9lVMFNzwLrtt27y7c8xk7Rijvl.jpg"};
        myDict[18] = new HashSet<string>() { "Thailand", "https://thumbs.dreamstime.com/b/map-thailand-outline-silhouette-vector-illustration-137914539.jpg"};
        myDict[19] = new HashSet<string>() { "Sweden", "https://vemaps.com/uploads/img/big/se-01.jpg"};
        myDict[20] = new HashSet<string>() { "Norway", "https://vemaps.com/uploads/img/big/no-01.jpg"};
        myDict[21] = new HashSet<string>() { "Austria", "https://thumbs.dreamstime.com/b/austria-outline-map-vector-illustration-isolated-white-background-125574368.jpg"};
        myDict[22] = new HashSet<string>() { "Ukraine", "https://previews.123rf.com/images/chrupka/chrupka1503/chrupka150300066/38348026-black-outline-of-ukraine-map.jpg"};
        myDict[23] = new HashSet<string>() { "Belgium", "https://static.vecteezy.com/system/resources/previews/008/726/875/original/map-of-belgium-outline-map-illustration-free-vector.jpg"};
        myDict[24] = new HashSet<string>() { "Australia", "https://openclipart.org/image/800px/16210"};
        myDict[25] = new HashSet<string>() { "Iran", "https://www.burningcompass.com/countries/iran/maps/iran-outline-map.jpg"};
        myDict[26] = new HashSet<string>() { "Canada", "https://media.istockphoto.com/id/833017722/vector/canada-map-of-black-contour-curves-of-vector-illustration.jpg?s=612x612&w=0&k=20&c=VdYE-7SZl932_oIr1FQEOtjpIxuTfQhYUrt_b7akIJE="};
        myDict[27] = new HashSet<string>() { "Brazil", "https://thumbs.dreamstime.com/b/brazil-outline-map-vector-illustration-isolated-white-background-125575261.jpg"};
        myDict[28] = new HashSet<string>() { "Malaysia", "https://previews.123rf.com/images/olleg/olleg1901/olleg190101021/116004164-map-of-malaysia-outline-silhouette-of-malaysia-map-illustration.jpg"};
        myDict[29] = new HashSet<string>() { "South Africa", "https://worldmapblank.com/wp-content/uploads/2020/12/South-Africa-Blank-map-Outline.jpg"};
        myDict[30] = new HashSet<string>() { "Philippines", "https://previews.123rf.com/images/stringerphotography/stringerphotography1508/stringerphotography150803223/43975188-a-high-detailed-outline-of-the-country-of-philippines.jpg"};
        myDict[31] = new HashSet<string>() { "Nigeria", "https://previews.123rf.com/images/chrupka/chrupka1908/chrupka190800223/128870970-black-outline-of-nigeria-map-vector-illustration.jpg"};
        myDict[32] = new HashSet<string>() { "Colombia", "https://vemaps.com/uploads/img/big/co-01.jpg"};
        myDict[33] = new HashSet<string>() { "Bangladesh", "https://i.pinimg.com/736x/ca/a4/d3/caa4d389f914f19ff6f20b60fca9e96c.jpg"};
        myDict[34] = new HashSet<string>() { "Argentina", "https://static.vecteezy.com/system/resources/previews/002/905/377/original/outline-simple-map-of-argentina-free-vector.jpg"};
        myDict[35] = new HashSet<string>() { "Egypt", "https://thumbs.dreamstime.com/z/egypt-map-icon-simple-style-outline-illustration-vector-web-83817621.jpg"};
        myDict[36] = new HashSet<string>() { "Vietnam", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQMzrt1LFU8Ff2aNy0kW_9PgeHo69uSKWsar3OZnlKa&s"};
        myDict[37] = new HashSet<string>() { "Pakistan", "https://i.pinimg.com/originals/f2/74/21/f2742141f7419b60a75a54bff443515f.png"};
        myDict[38] = new HashSet<string>() { "Romania", "https://openclipart.org/image/800px/23976"};
        myDict[39] = new HashSet<string>() { "Chile", "https://fvmstatic.s3.amazonaws.com/maps/m/CL-EPS-01-0004.png"};
        myDict[40] = new HashSet<string>() { "Iraq", "https://thumbs.dreamstime.com/b/iraq-map-outline-vector-illustration-isolated-white-background-iraq-map-outline-vector-illustration-125596872.jpg"};
        myDict[41] = new HashSet<string>() { "Greece", "https://media.istockphoto.com/id/1310060837/vector/vector-illustration-of-the-map-of-greece-on-white-background.jpg?s=612x612&w=0&k=20&c=8VPJFzG_zMU626KoZQMMnTT1DuQp0cqSeoX-ZoQXEeo=" };
        myDict[42] = new HashSet<string>() { "Kazakhstan", "https://i.pinimg.com/originals/b5/e9/38/b5e938f945f3fa46c8816e3369eb9744.gif" };
        myDict[43] = new HashSet<string>() { "Morocco", "https://thumbs.dreamstime.com/b/morocco-map-outline-vector-illustration-morocco-map-outline-vector-illustration-isolated-white-background-125659488.jpg"};
        myDict[44] = new HashSet<string>() { "Czech Republic", "https://coloringonly.com/images/imgcolor/Czech-Republic-Outline-Map-coloring-page.jpg"};
        myDict[45] = new HashSet<string>() { "Portugal", "https://ecdn.teacherspayteachers.com/thumbitem/Portugal-Country-Map-Black-White-Solid-Outline-Maps-JPG-SVG-PNG-PDF-EPS-AI-6435095-1610338522/original-6435095-3.jpg"};
        myDict[46] = new HashSet<string>() { "Peru", "https://www.worldatlas.com/upload/e0/4c/37/pe-03.png"};
        myDict[47] = new HashSet<string>() { "Venezuela", "https://thumbs.dreamstime.com/b/venezuela-map-outline-vector-illustartion-venezuela-map-outline-vector-illustartion-isolated-white-background-125675046.jpg"};
        myDict[48] = new HashSet<string>() { "Uzbekistan", "https://schools.look4.net.nz/geography/country_information/outline_maps/files_OM/uzbekistan.jpg"};
        myDict[49] = new HashSet<string>() { "Malawi", "https://vemaps.com/uploads/img/big/mw-01.jpg"};
        myDict[50] = new HashSet<string>() { "Niger", "https://thumbs.dreamstime.com/b/niger-map-outline-vector-illustration-isolated-white-background-niger-map-outline-vector-illustration-125659710.jpg"};
        myDict[51] = new HashSet<string>() { "Sri Lanka", "https://www.burningcompass.com/countries/sri-lanka/maps/sri-lanka-outline-map.jpg"};
        myDict[52] = new HashSet<string>() { "Madagascar", "https://www.burningcompass.com/countries/madagascar/maps/madagascar-outline-map.jpg"};
        myDict[53] = new HashSet<string>() { "North Korea", "https://cdn2.vectorstock.com/i/thumb-large/15/46/north-korea-map-of-black-contour-curves-on-white-vector-18981546.jpg"};
        myDict[54] = new HashSet<string>() { "Taiwan" };
        myDict[55] = new HashSet<string>() { "Australia" };
        myDict[56] = new HashSet<string>() { "Syria" };
        myDict[57] = new HashSet<string>() { "Ivory Coast" };
        myDict[58] = new HashSet<string>() { "Cameroon" };
        myDict[59] = new HashSet<string>() { "Cambodia" };
        myDict[60] = new HashSet<string>() { "Somalia" };
        myDict[61] = new HashSet<string>() { "Senegal" };
        myDict[62] = new HashSet<string>() { "Chad" };
        myDict[63] = new HashSet<string>() { "Zimbabwe" };
        myDict[64] = new HashSet<string>() { "Guinea" };
        myDict[65] = new HashSet<string>() { "Rwanda" };
        myDict[66] = new HashSet<string>() { "Benin" };
        myDict[67] = new HashSet<string>() { "Burundi" };
        myDict[68] = new HashSet<string>() { "Tunisia" };
        myDict[69] = new HashSet<string>() { "South Sudan" };
        myDict[70] = new HashSet<string>() { "Bolivia" };
        myDict[71] = new HashSet<string>() { "Belarus" };
        myDict[72] = new HashSet<string>() { "Haiti" };
        myDict[73] = new HashSet<string>() { "Dominican Republic" };
        myDict[74] = new HashSet<string>() { "Sweden" };
        myDict[75] = new HashSet<string>() { "Azerbaijan" };
        myDict[76] = new HashSet<string>() { "United Arab Emirates" };
        myDict[77] = new HashSet<string>() { "Tajikistan" };
        myDict[78] = new HashSet<string>() { "Israel" };
        myDict[79] = new HashSet<string>() { "Hong Kong" };
        myDict[80] = new HashSet<string>() { "Jordan" };
        myDict[81] = new HashSet<string>() { "Switzerland" };
        myDict[82] = new HashSet<string>() { "Togo" };
        myDict[83] = new HashSet<string>() { "Sierra Leone" };
        myDict[84] = new HashSet<string>() { "Laos" };
        myDict[85] = new HashSet<string>() { "Paraguay" };
        myDict[86] = new HashSet<string>() { "Bulgaria" };
        myDict[87] = new HashSet<string>() { "Libya" };
        myDict[88] = new HashSet<string>() { "Lebanon" };
        myDict[89] = new HashSet<string>() { "Nicaragua" };
        myDict[90] = new HashSet<string>() { "Kyrgyzstan" };
        myDict[91] = new HashSet<string>() { "El Salvador" };
        myDict[92] = new HashSet<string>() { "Singapore" };
        myDict[93] = new HashSet<string>() { "Denmark" };
        myDict[94] = new HashSet<string>() { "Finland" };
        myDict[95] = new HashSet<string>() { "Slovakia" };
        myDict[96] = new HashSet<string>() { "Norway" };
        myDict[97] = new HashSet<string>() { "Eritrea" };
        myDict[98] = new HashSet<string>() { "Oman" };
        myDict[99] = new HashSet<string>() { "Palestine" };
        myDict[100] = new HashSet<string>() { "Costa Rica" };
    public void fillCountries() {

        myDict[0] = new HashSet<string>() { "China", "https://www.burningcompass.com/countries/china/maps/china-outline-map.jpg" };
        myDict[1] = new HashSet<string>() { "United States of America", "https://media.istockphoto.com/id/835357658/vector/usa-map.jpg?s=612x612&w=0&k=20&c=2NWn9P2Zdcfn73WIESjUvoc0rWJaDVP24ZhT6hkcBzw=" };
        myDict[2] = new HashSet<string>() { "Japan", "https://vemaps.com/uploads/img/big/jp-01.jpg" };
        myDict[3] = new HashSet<string>() { "India" };
        myDict[4] = new HashSet<string>() { "United Kingdom" };
        myDict[5] = new HashSet<string>() { "Germany" };
        myDict[6] = new HashSet<string>() { "France" };
        myDict[7] = new HashSet<string>() { "Italy" };
        myDict[8] = new HashSet<string>() { "South Korea" };
        myDict[9] = new HashSet<string>() { "Spain" };
        myDict[10] = new HashSet<string>() { "Russia" };
        myDict[11] = new HashSet<string>() { "Mexico" };
        myDict[12] = new HashSet<string>() { "Indonesia" };
        myDict[13] = new HashSet<string>() { "Turkey" };
        myDict[14] = new HashSet<string>() { "Netherlands" };
        myDict[15] = new HashSet<string>() { "Saudi Arabia" };
        myDict[16] = new HashSet<string>() { "Switzerland" };
        myDict[17] = new HashSet<string>() { "Poland" };
        myDict[18] = new HashSet<string>() { "Thailand" };
        myDict[19] = new HashSet<string>() { "Sweden" };
        myDict[20] = new HashSet<string>() { "Norway" };
        myDict[21] = new HashSet<string>() { "Austria" };
        myDict[22] = new HashSet<string>() { "Ukraine" };
        myDict[23] = new HashSet<string>() { "Belgium" };
        myDict[24] = new HashSet<string>() { "Australia" };
        myDict[25] = new HashSet<string>() { "Iran" };
        myDict[26] = new HashSet<string>() { "Canada" };
        myDict[27] = new HashSet<string>() { "Brazil" };
        myDict[28] = new HashSet<string>() { "Malaysia" };
        myDict[29] = new HashSet<string>() { "South Africa" };
        myDict[30] = new HashSet<string>() { "Philippines" };
        myDict[31] = new HashSet<string>() { "Nigeria" };
        myDict[32] = new HashSet<string>() { "Colombia" };
        myDict[33] = new HashSet<string>() { "Bangladesh" };
        myDict[34] = new HashSet<string>() { "Argentina" };
        myDict[35] = new HashSet<string>() { "Egypt" };
        myDict[36] = new HashSet<string>() { "Vietnam" };
        myDict[37] = new HashSet<string>() { "Pakistan" };
        myDict[38] = new HashSet<string>() { "Romania" };
        myDict[39] = new HashSet<string>() { "Chile" };
        myDict[40] = new HashSet<string>() { "Iraq" };
        myDict[41] = new HashSet<string>() { "Greece" };
        myDict[42] = new HashSet<string>() { "Kazakhstan" };
        myDict[43] = new HashSet<string>() { "Morocco" };
        myDict[44] = new HashSet<string>() { "Czech Republic" };
        myDict[45] = new HashSet<string>() { "Portugal" };
        myDict[46] = new HashSet<string>() { "Peru" };
        myDict[47] = new HashSet<string>() { "Venezuela" };
        myDict[48] = new HashSet<string>() { "Uzbekistan" };
        myDict[49] = new HashSet<string>() { "Malawi" };
        myDict[50] = new HashSet<string>() { "Niger" };
        myDict[51] = new HashSet<string>() { "Sri Lanka" };
        myDict[52] = new HashSet<string>() { "Madagascar" };
        myDict[53] = new HashSet<string>() { "North Korea" };
        myDict[54] = new HashSet<string>() { "Taiwan", "https://www.worldmaphd.com/taiwan/blank-map-of-taiwan/blank-map-of-taiwan.png"};
        myDict[55] = new HashSet<string>() { "Australia", "https://external-content.duckduckgo.com/iu/?u=http%3A%2F%2Fwww.clipartbest.com%2Fcliparts%2F7ia%2FKyE%2F7iaKyExjT.png&f=1&nofb=1&ipt=a04fd26bd4f47e555d79e832a4c14b57925f7931a7ebcca68ee8c9a6e753e212&ipo=images" };
        myDict[56] = new HashSet<string>() { "Syria", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fwww.worldatlas.com%2Fwebimage%2Fcountrys%2Fasia%2Foutline%2Fsyout.gif&f=1&nofb=1&ipt=d0578f138051f86cfc392e5baec0cc6a0ab12df89200177ce661fd082b828f96&ipo=images" };
        myDict[57] = new HashSet<string>() { "Ivory Coast", "https://i.pinimg.com/originals/c1/e0/f0/c1e0f061b01b7d87f30a982991e3b73c.png" };
        myDict[58] = new HashSet<string>() { "Cameroon", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fwww.worldmaphd.com%2Fcameroon%2Fblank-map-of-cameroon%2Fblank-map-of-cameroon.png&f=1&nofb=1&ipt=de0656d39d00d715405d7dcb00275c699477db4408f4126dd9a1bc48b29678d7&ipo=images" };
        myDict[59] = new HashSet<string>() { "Cambodia", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fmaps-cambodia.com%2Fimg%2F1200%2Fcambodia-map-outline.jpg&f=1&nofb=1&ipt=19ee21cffedd79329ff71bfb6e9a80d52bf743f8de6209234d6cf1e58a739886&ipo=images" };
        myDict[60] = new HashSet<string>() { "Somalia", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fd-maps.com%2Fm%2Fafrica%2Fsomalie%2Fsomalie04.gif&f=1&nofb=1&ipt=462be1fb829d9552271e83929e66c24a44771bd8897bd06c2151dae492d2f0cc&ipo=images" };
        myDict[61] = new HashSet<string>() { "Senegal", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fwww.worldmaphd.com%2Fsenegal%2Fblank-map-of-senegal%2Fblank-map-of-senegal.png&f=1&nofb=1&ipt=be36426454f884e1b5439b14298ca689a8f46cda78f131451d0ec5ea38c2774f&ipo=images" };
        myDict[62] = new HashSet<string>() { "Chad", "https://external-content.duckduckgo.com/iu/?u=http%3A%2F%2Fwww.aneki.com%2Fmaps_blank%2FChad_blank_outline_map.gif&f=1&nofb=1&ipt=3e439b05f5d573a0c7a76212c170e88e9b518609ef66df16a15801bf8d4f16f8&ipo=images" };
        myDict[63] = new HashSet<string>() { "Zimbabwe", "https://www.worldmaphd.com/zimbabwe/blank-map-of-zimbabwe/blank-map-of-zimbabwe.png" };
        myDict[64] = new HashSet<string>() { "Guinea", "https://media.business-humanrights.org/media/original_images/filesGuinea-outline-map-credit-Matt-Rosenberg-About_com-geography.jpg" };
        myDict[65] = new HashSet<string>() { "Rwanda", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fblankmapsrepo.com%2Fwp-content%2Fuploads%2F2022%2F06%2Frwanda-outline-map.png&f=1&nofb=1&ipt=0fb30b50d65317f726ea60d9652c73723c116d4c9f0d9ebc2b7d0101578ea55e&ipo=images" };
        myDict[66] = new HashSet<string>() { "Benin", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fwww.worldmaphd.com%2Fbenin%2Fblank-map-of-benin%2Fblank-map-of-benin.png&f=1&nofb=1&ipt=d6a87a0892989e2ab0666a04a5ba4c5154a31a7c008a8cb751cd9dc70b58ea2f&ipo=images" };
        myDict[67] = new HashSet<string>() { "Burundi", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fwww.worldmaphd.com%2Fburundi%2Fblank-map-of-burundi%2Fblank-map-of-burundi.png&f=1&nofb=1&ipt=38267d238bf34b7c4e7b6b7983940915913b1d60d0604c2bc25a6eee3b49547d&ipo=images" };
        myDict[68] = new HashSet<string>() { "Tunisia", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fwww.worldmaphd.com%2Ftunisia%2Fblank-map-of-tunisia%2Fblank-map-of-tunisia.png&f=1&nofb=1&ipt=fb2b042c0ad6653326d216580575adcb8e74dcbb2c53bb514a12c3b7ece652f5&ipo=images" };
        myDict[69] = new HashSet<string>() { "South Sudan", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fartsphere.org%2Fwp-content%2Fuploads%2F2021%2F02%2FSouth_Sudan_Blank-adjusted-Resized-1024x512.png&f=1&nofb=1&ipt=965dfb9f456f4b6037e0fc02ab85f2f88035f33071d9d4c6f6bb468642dcb69a&ipo=images" };
        myDict[70] = new HashSet<string>() { "Bolivia", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fd-maps.com%2Fm%2Famerica%2Fbolivia%2Fbolivie%2Fbolivie38.gif&f=1&nofb=1&ipt=69363bf4aafa6cd5509b3e4487243fbffd6a89e4bb593fa5673882925b56a0b8&ipo=images" };
        myDict[71] = new HashSet<string>() { "Belarus", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fwww.worldatlas.com%2Fwebimage%2Fcountrys%2Feurope%2Foutline%2Fby.gif&f=1&nofb=1&ipt=cdbaed7dddab2c396cfb45df2df1231727d791a85126916b9d35c38c8b0b3f95&ipo=images" };
        myDict[72] = new HashSet<string>() { "Haiti", "https://external-content.duckduckgo.com/iu/?u=http%3A%2F%2F4.bp.blogspot.com%2F-B9oYoOZLaWM%2FTy5OpRhDhRI%2FAAAAAAAAM1s%2FpNZE2O92NcA%2Fs1600%2FHaiti-Kontur.png&f=1&nofb=1&ipt=6c108ddc36391a8cc0a416afa3ee1c6f6fea433b2316daa01e5d507d4c57351e&ipo=images" };
        myDict[73] = new HashSet<string>() { "Dominican Republic", "https://external-content.duckduckgo.com/iu/?u=http%3A%2F%2Fwww.worldatlas.com%2Fwebimage%2Fcountrys%2Fnamerica%2Fcaribb%2Foutline%2Fdo.gif&f=1&nofb=1&ipt=10f886d1598f6addc09673adc20bbfe05570e0590af647274804bc7e8e25b28d&ipo=images" };
        myDict[74] = new HashSet<string>() { "Sweden", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fi.pinimg.com%2F736x%2F3e%2Ff4%2F1b%2F3ef41b3756c0491808321746553e57c4--free-printables-sweden.jpg&f=1&nofb=1&ipt=d0854cb41a7cec2a06f03783277489934bd688a27f00624d1bbe403186414733&ipo=images" };
        myDict[75] = new HashSet<string>() { "Azerbaijan", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fworldmapblank.com%2Fwp-content%2Fuploads%2F2020%2F07%2FTransparent-PNG-Azerbaijan-Map.png&f=1&nofb=1&ipt=e7e3b7c25568a5fcaa175ee9aa897a7c2fdf6d5710f81cebfd44540fc4c2067e&ipo=images" };
        myDict[76] = new HashSet<string>() { "United Arab Emirates", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fcoloringonly.com%2Fimages%2Fimgcolor%2FUnited-Arab-Emirates-Outline-Map-coloring-page.jpg&f=1&nofb=1&ipt=0836d3624766a54a1f89ee81656fb23a4a7bf906260b9b85ae39311a3a303e8c&ipo=images" };
        myDict[77] = new HashSet<string>() { "Tajikistan", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fwww.quia.com%2Ffiles%2Fquia%2Fusers%2Fmrwrightcechs%2FMaps%2FTajikistan.jpg&f=1&nofb=1&ipt=d6f8dd6f66ca83656ed6c21b562449cda0f87b7ac9e0b80d9a65740592c6ed86&ipo=images" };
        myDict[78] = new HashSet<string>() { "Israel", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fvemaps.com%2Fuploads%2Fimg%2Fbig%2Fil-02.jpg&f=1&nofb=1&ipt=431185068930d2f6ec6e958bb70e07bf1b07d98bf2cd49d18f456ae7c079d802&ipo=images" };
        myDict[79] = new HashSet<string>() { "Hong Kong", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fwww.worldatlas.com%2Fwebimage%2Fcountrys%2Fasia%2Foutline%2Fhkout.gif&f=1&nofb=1&ipt=566fd7412352c09b672dc7baff2519fa64e973e61d7238ef3fa9466dfa196ee9&ipo=images" };
        myDict[80] = new HashSet<string>() { "Jordan", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fwww.worldmaphd.com%2Fjordan%2Fblank-map-of-jordan%2Fblank-map-of-jordan.png&f=1&nofb=1&ipt=affa60c2d7dfe002afb98a070b6f8875260f514995927cf74d04899a039d9a34&ipo=images" };
        myDict[81] = new HashSet<string>() { "Switzerland", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fi.pinimg.com%2F736x%2Ff9%2F1f%2Fae%2Ff91fae1c705ed99549d00aca104bc21a--countries-europe-printable-maps.jpg&f=1&nofb=1&ipt=ff5c3662ccefd5c98aa72c4cc0ea15fe521d2f121915a8443b4b1e116c318169&ipo=images" };
        myDict[82] = new HashSet<string>() { "Togo", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fi.pinimg.com%2F736x%2F36%2Fc9%2Fed%2F36c9ed9c1f59db7cd989aec82bd58cf3.jpg&f=1&nofb=1&ipt=8079303d647f1e6a829212e0dcbb90bd8cfea1f01e1c3884c2b2ecd481ca675a&ipo=images" };
        myDict[83] = new HashSet<string>() { "Sierra Leone", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fwww.worldatlas.com%2Fwebimage%2Fcountrys%2Fafrica%2Foutline%2Fslout.gif&f=1&nofb=1&ipt=b79cef516ac4d2474cfc38e625bbdd5a84d53b3d6551ddad8af15fdeb987ff50&ipo=images" };
        myDict[84] = new HashSet<string>() { "Laos", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fwww.worldatlas.com%2Fwebimage%2Fcountrys%2Fasia%2Foutline%2Flaout.gif&f=1&nofb=1&ipt=9498cc42fbaf2d20c27076a1220cc8328c09a9ae94697576a9fd32bc9bb22239&ipo=images" };
        myDict[85] = new HashSet<string>() { "Paraguay", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fstatic.vecteezy.com%2Fsystem%2Fresources%2Fpreviews%2F003%2F087%2F839%2Flarge_2x%2Foutline-simple-map-of-paraguay-free-vector.jpg&f=1&nofb=1&ipt=e5bad653cbad375657196424f6958b7b123f189f354e3c791347ab2c14b152cd&ipo=images" };
        myDict[86] = new HashSet<string>() { "Bulgaria", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fimg.favpng.com%2F16%2F6%2F24%2Fblank-map-flag-of-bulgaria-vector-map-png-favpng-2zww4HV5RAWQPRK7fVbfh4330.jpg&f=1&nofb=1&ipt=f4f028318f5a137d02660614de857febf0caf413c4e0b86d0fbb74cd421dacbe&ipo=images" };
        myDict[87] = new HashSet<string>() { "Libya", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fd2z7bzwflv7old.cloudfront.net%2Fcdn_image%2FexH_600%2Fimages%2Fmaps%2Fen%2Fly%2Fly-nonameoutline.gif&f=1&nofb=1&ipt=7fa6f7da5a656103bbfe5330932338014446b8b5f4457c63dfaebdb10dc16468&ipo=images" };
        myDict[88] = new HashSet<string>() { "Lebanon", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fvectorified.com%2Fimage%2Flebanon-map-vector-26.jpg&f=1&nofb=1&ipt=1a89bbbe8ec89834a338674e5e155e638b217ea1826ca5db93502bdab9cff7ac&ipo=images" };
        myDict[89] = new HashSet<string>() { "Nicaragua", "https://external-content.duckduckgo.com/iu/?u=http%3A%2F%2Fwww.aneki.com%2Fmaps_blank%2FNicaragua_blank_outline_map.gif&f=1&nofb=1&ipt=c187f19ab19de811628d8216b55344012b4414e287c3aaa719c9303d2e685678&ipo=images" };
        myDict[90] = new HashSet<string>() { "Kyrgyzstan", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fimages.fineartamerica.com%2Fimages%2Fartworkimages%2Fmediumlarge%2F2%2Fkyrgyzstan-map-outline-bigalbaloo-stock.jpg&f=1&nofb=1&ipt=43a18f594c9e40d404ae7572b9a517d385728ebfcea40e01c60a6e6efa7024b6&ipo=images" };
        myDict[91] = new HashSet<string>() { "El Salvador", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fstatic.vecteezy.com%2Fsystem%2Fresources%2Fpreviews%2F003%2F087%2F776%2Flarge_2x%2Foutline-simple-map-of-el-salvador-free-vector.jpg&f=1&nofb=1&ipt=7663fb890ccce23d27fee7cbd47551cb684d88d230b8873b45c081946dbe5fe2&ipo=images" };
        myDict[92] = new HashSet<string>() { "Singapore", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fwww.worldatlas.com%2Fr%2Fw1200%2Fupload%2F18%2Fbc%2Fff%2Fsg-03.jpg&f=1&nofb=1&ipt=b309829e0fc6302f317f18dc70016a910ad45b3c3e6ce7860c1b05bd4d89f0a6&ipo=images" };
        myDict[93] = new HashSet<string>() { "Denmark", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fc1.staticflickr.com%2F2%2F1074%2F644434691_6462639931.jpg&f=1&nofb=1&ipt=650f3581b922ee32912fcb369ad481c44d320fb7e39f291f327b69bb111af78e&ipo=images" };
        myDict[94] = new HashSet<string>() { "Finland", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fi.pinimg.com%2Foriginals%2F3c%2Fa4%2Fdb%2F3ca4dba1c68371c22f020c976e42aa42.jpg&f=1&nofb=1&ipt=80f74c1ca3c929ca701148fa364698e5879086b417a01b328e4ddef424f76d24&ipo=images" };
        myDict[95] = new HashSet<string>() { "Slovakia", "https://openclipart.org/image/2400px/svg_to_png/247755/SlovakiaOutline.png" };
        myDict[96] = new HashSet<string>() { "Norway", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fimages.onlinelabels.com%2Fimages%2Fclip-art%2FAnonymous%2FAnonymous_Map_of_Norway.png&f=1&nofb=1&ipt=f69dbe83fbdcfc64b5702dc0220177ec4346fd136154e99ccb41f8b55fec95b5&ipo=images" };
        myDict[97] = new HashSet<string>() { "Eritrea", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fd2z7bzwflv7old.cloudfront.net%2Fcdn_image%2FexH_600%2Fimages%2Fmaps%2Fen%2Fer%2Fer-nonameoutline.gif&f=1&nofb=1&ipt=c6cece7bce751ccc01237035fa3ab5eddda0bd693de8b33da962b3d307629f1a&ipo=images" };
        myDict[98] = new HashSet<string>() { "Oman", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fwww.worldmaphd.com%2Foman%2Fblank-map-of-oman%2Fblank-map-of-oman.png&f=1&nofb=1&ipt=20e6a2293b24fd1de2a77f3f426dd9365b5cbbaf3df6fc51300a789fa5271f8c&ipo=images" };
        myDict[99] = new HashSet<string>() { "Costa Rica", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fwww.worldatlas.com%2Fwebimage%2Fcountrys%2Fnamerica%2Fcamerica%2Foutline%2Fcroutl.gif&f=1&nofb=1&ipt=94f31dd7d9ae4c7adfdf00b734b768db2136a1fb245a48c28498cceb9774bb0e&ipo=images" };



    }



    public Dictionary<int, HashSet<string>> getCountries()
    {
        return myDict;
    }
    
    public Dictionary<int, HashSet<string>> getCountries()
    {
        return myDict;
    }
    
}
