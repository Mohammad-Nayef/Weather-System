using AutoFixture;
using FluentAssertions;
using WeatherSystem.Models;

namespace WeatherSystem.Test
{
    public class WeatherBotDTOTest
    {
        Fixture fixture = new();
        WeatherStateDTO weatherState;
        WeatherBotDTO sut;

        public WeatherBotDTOTest()
        {
            sut = fixture.Create<WeatherBotDTO>();
            weatherState = fixture.Create<WeatherStateDTO>();
            sut.TemperatureUnderThreshold = sut.TemperatureAboveThreshold - 2;
        }

        [Fact]
        public void ThresholdsShouldNotBeTriggered()
        {
            // Act
            weatherState.Temperature = (float)sut.TemperatureAboveThreshold - 1;
            weatherState.Humidity = (float)sut.HumidityThreshold - 1;
            sut.CheckThresholds(weatherState);


            // Assert
            sut.IsThresholdTriggered.Should().BeFalse();
        }

        [Fact]
        public void HumidityThresholdShouldBeTriggered()
        {
            // Act
            weatherState.Temperature = (float)sut.TemperatureAboveThreshold - 1;
            weatherState.Humidity = (float)sut.HumidityThreshold + 1;
            sut.CheckThresholds(weatherState);

            // Assert
            sut.IsThresholdTriggered.Should().BeTrue();
        }

      
    }
}