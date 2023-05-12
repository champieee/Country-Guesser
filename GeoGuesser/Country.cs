using System;
using System.Threading;
using System.Collections.Generic;
using System.Collections;

class Country {

public Country(){

}

Dictionary<int, Array> countries = new Dictionary<int, Array>();
Dictionary<int, HashSet<string>> myDict = new Dictionary<int, HashSet<string>>();

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
