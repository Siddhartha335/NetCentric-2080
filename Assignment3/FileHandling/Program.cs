InflationAnalysis analysis = new InflationAnalysis();

    // Adjust the file path accordingly
    string filePath = "Inflation.csv";
    analysis.ReadCsv(filePath);

    // Example usages:
    var inflationRates2021 = analysis.GetInflationRatesForYear(2021);
    var highestInflationNepal = analysis.GetYearWithHighestInflationForCountry("Nepal");
    var top10RegionsHighestInflation = analysis.GetTopRegionsWithHighestInflation(10);
    var top3SouthAsianLowestInflation2020 = analysis.GetTopSouthAsianCountriesWithLowestInflationForYear(2020, 3);

    Console.WriteLine("Inflation rates for 2021:");
    foreach (var rate in inflationRates2021)
    {
        Console.WriteLine($"{rate.RegionalMember} - {rate.Inflations}%");
    }

    if (highestInflationNepal != null)
    {
        Console.WriteLine($"\nYear when Nepal had highest inflation: {highestInflationNepal.Year} with {highestInflationNepal.Inflations}%");
    }

    Console.WriteLine("\nTop 10 regions with highest inflation:");
    foreach (var region in top10RegionsHighestInflation)
    {
        Console.WriteLine($"{region.RegionalMember} - {region.Inflations}%");
    }

    Console.WriteLine("\nTop 3 South Asian countries with lowest inflation rate for 2020:");
    foreach (var country in top3SouthAsianLowestInflation2020)
    {
        Console.WriteLine($"{country.RegionalMember} - {country.Inflations}%");
    }