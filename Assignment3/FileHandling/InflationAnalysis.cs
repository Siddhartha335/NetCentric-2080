using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;


public class CustomIntConverter : DefaultTypeConverter
{
    public override object ConvertFromString(string text, IReaderRow row, MemberMapData memberMapData)
    {
        if (int.TryParse(text, out var result))
        {
            return result;
        }
        return 0; // Default value or handle as needed
    }
}

public class CustomDoubleConverter : DefaultTypeConverter
{
    public override object ConvertFromString(string text, IReaderRow row, MemberMapData memberMapData)
    {
        if (double.TryParse(text, out var result))
        {
            return result;
        }
        return 0.0; // Default value or handle as needed
    }
}

public class InflationMap : ClassMap<Inflation>
{
    public InflationMap()
    {
        Map(m => m.RegionalMember).Name("RegionalMember");
        Map(m => m.Year).Name("Year").TypeConverter<CustomIntConverter>();
        Map(m => m.Inflations).Name("Inflations").TypeConverter<CustomDoubleConverter>();
        Map(m => m.UnitOfMeasurement).Name("UnitOfMeasurement");
        Map(m => m.SubRegion).Name("SubRegion");
        Map(m => m.CountryCode).Name("CountryCode");
    }
}

public class InflationAnalysis
{
    public List<Inflation> Inflations { get; private set; } = new List<Inflation>();

    public void ReadCsv(string filePath)
    {
        var config = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            TrimOptions = TrimOptions.Trim,
            PrepareHeaderForMatch = args => args.Header.Trim(),
            HeaderValidated = null, // Ignore missing headers
            MissingFieldFound = null // Ignore missing fields
        };

        using (var reader = new StreamReader(filePath))
        using (var csv = new CsvReader(reader, config))
        {
            csv.Context.RegisterClassMap<InflationMap>();
            Inflations = csv.GetRecords<Inflation>().ToList();
        }
    }

    public IEnumerable<Inflation> GetInflationRatesForYear(int year)
    {
        return Inflations.Where(i => i.Year == year);
    }

    public Inflation GetYearWithHighestInflationForCountry(string country)
    {
        return Inflations.Where(i => i.RegionalMember.Equals(country, StringComparison.OrdinalIgnoreCase))
                         .OrderByDescending(i => i.Inflations)
                         .FirstOrDefault();
    }

    public IEnumerable<Inflation> GetTopRegionsWithHighestInflation(int topCount)
    {
        return Inflations.OrderByDescending(i => i.Inflations).Take(topCount);
    }

    public IEnumerable<Inflation> GetTopSouthAsianCountriesWithLowestInflationForYear(int year, int topCount)
    {
        return Inflations.Where(i => i.Year == year && i.SubRegion != null && i.SubRegion.Equals("South Asia", StringComparison.OrdinalIgnoreCase))
                         .OrderBy(i => i.Inflations)
                         .Take(topCount);
    }
}