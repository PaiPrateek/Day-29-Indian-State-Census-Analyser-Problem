﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using IndianStateCensusAnalyserProblem.POCO;
using Newtonsoft.Json;

namespace IndianStateCensusAnalyserProblem
{
    public  class CensusAnalyser
    {
        public enum Country
        {
            INDIA , US, BRAZIL
        }
        Dictionary<string, CensusDTO> dataMap;
        public Dictionary<string, CensusDTO> LoadCensusData(Country country, string csvFilePath, string dataHeaders)
        {   
            dataMap = new CSVAdapterFactory().LoadCsvData(country, csvFilePath, dataHeaders);
            return dataMap;
        }
    }
}
