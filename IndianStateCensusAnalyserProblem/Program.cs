using System;

namespace IndianStateCensusAnalyserProblem
{
    internal class ProgramH
    {
        // CSV Firl Paths 
        static string indianStateCensusHeaders = "State,Population,AreaInSqKm,DensityPerSqKm";

        static string indianStateCodeHeaders = "SrNo,State Name,TIN,StateCode";

        static string indianStateCensusFilePath = @"E:\LFP158\Assignment\Day 29\IndianStateCensusAnalyserProblem\IndianStateCensusAnalyserProblem\CSV\IndiaStateCensusData.csv";
        static string wrongIndianStateCensusFilePath = @"E:\LFP158\Assignment\Day 29\IndianStateCensusAnalyserProblem\IndianStateCensusAnalyserProblem\CSV\IndiaData.csv";
        static string wrongIndianStateCensusFileType = @"E:\LFP158\Assignment\Day 29\IndianStateCensusAnalyserProblem\IndianStateCensusAnalyserProblem\CSV\IndianStateCensus.txt";
        static string delimiterIndianCensusFilePath = @"E:\LFP158\Assignment\Day 29\IndianStateCensusAnalyserProblem\IndianStateCensusAnalyserProblem\CSV\IndianStateCesusDelimeter.csv";
        static string wrongHeaderIndianCensusFilePath = @"E:\LFP158\Assignment\Day 29\IndianStateCensusAnalyserProblem\IndianStateCensusAnalyserProblem\CSV\WrongIndiaStateCensusData.csv";

        static string indianStateCodeFilePath = @"E:\LFP158\Assignment\Day 29\IndianStateCensusAnalyserProblem\IndianStateCensusAnalyserProblem\CSV\IndiaStateCodes.csv";
        static string wrongIndianStateCodeFilePath = @"E:\LFP158\Assignment\Day 29\IndianStateCensusAnalyserProblem\IndianStateCensusAnalyserProblem\CSV\StateCodeData.csv";


        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Indian State Census Analyser Problem ");

            IndianCensusAdapter indianCensusAdapter = new IndianCensusAdapter();

            // Loading the Census Data File
            indianCensusAdapter.LoadCensusData(indianStateCensusFilePath,indianStateCensusHeaders);

            //1.2
            indianCensusAdapter.LoadCensusData(wrongIndianStateCensusFilePath, indianStateCensusHeaders);

            //1.3
            indianCensusAdapter.LoadCensusData(wrongIndianStateCensusFileType, indianStateCensusHeaders);

            //1.4
            indianCensusAdapter.LoadCensusData(delimiterIndianCensusFilePath, indianStateCensusHeaders);
            //1.4
            indianCensusAdapter.LoadCensusData(wrongHeaderIndianCensusFilePath, indianStateCensusHeaders);

            // Loading the State census Data File
            indianCensusAdapter.LoadCensusData(indianStateCodeFilePath, indianStateCodeHeaders);

            //2.2
            indianCensusAdapter.LoadCensusData(wrongIndianStateCodeFilePath, indianStateCodeHeaders);
        }
    }
}
