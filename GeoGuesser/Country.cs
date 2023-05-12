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

    }

    public Dictionary<int, HashSet<string>> getCountries()
    {
        return myDict;
    }
    
}
