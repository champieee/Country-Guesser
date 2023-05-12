using System;
using System.Threading;
using System.Collections.Generic;
using System.Collections;

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

    }



    public Dictionary<int, HashSet<string>> getCountries()
    {
        return myDict;
    }
    
}
