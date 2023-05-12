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
        string[] countryNames = new string[1];

        myDict[0] = new HashSet<string>() { "China", "https://www.burningcompass.com/countries/china/maps/china-outline-map.jpg" };
        myDict[1] = new HashSet<string>() { "United States of America", "https://media.istockphoto.com/id/835357658/vector/usa-map.jpg?s=612x612&w=0&k=20&c=2NWn9P2Zdcfn73WIESjUvoc0rWJaDVP24ZhT6hkcBzw=" };
        myDict[2] = new HashSet<string>() { "Japan", "https://vemaps.com/uploads/img/big/jp-01.jpg" };

        countryNames[0] = ("China");
        countryNames[1] = ("https://www.burningcompass.com/countries/china/maps/china-outline-map.jpg");
        countries.Add(0, countryNames);
        

        countryNames[0] = ("United States of America");
        countryNames[1] = ("https://media.istockphoto.com/id/835357658/vector/usa-map.jpg?s=612x612&w=0&k=20&c=2NWn9P2Zdcfn73WIESjUvoc0rWJaDVP24ZhT6hkcBzw=");
        countries.Add(1, countryNames);
        

        countryNames[0] = ("Japan");
        countryNames[1] = ("https://vemaps.com/uploads/img/big/jp-01.jpg");
        countries.Add(2, countryNames);
        
    }

    public Dictionary<int, HashSet<string>> getCountries()
    {
        return myDict;
    }
    
}





