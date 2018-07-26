#r "Microsoft.Azure.WebJobs.Extensions.DurableTask"

#load "..\shared\Location.csx"
#load "..\shared\WeatherUnderground.csx"

// This is an activity called by the monitoring pattern sample orchestrator.
public static async Task<bool> Run(Location location)
{
    var currentConditions = await WeatherUnderground.GetCurrentConditionsAsync(location);
    return currentConditions.Equals(WeatherCondition.Clear);
}