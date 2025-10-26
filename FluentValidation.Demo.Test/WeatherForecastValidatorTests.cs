using Xunit;

namespace FluentValidation.Demo.Test
{
    public class WeatherForecastValidatorTests
    {
        private readonly WeatherForecastValidator _validator = new WeatherForecastValidator();

        [Fact]
        public void GivenAnInvalidTemperatureCValue_ShouldHaveValidationError()
            => _validator.ShouldHaveValidationErrorFor(model => model.TemperatureC, 101);
    }
}
