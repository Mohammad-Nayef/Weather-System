using AutoFixture;
using FluentAssertions;
using WeatherSystem.Models;

namespace WeatherSystem.Test
{
    public class WeatherBotDTOTest
    {
        Fixture fixture = new();
        WeatherStateDTO weatherState;
        WeatherBotDTO weatherBot;

        public WeatherBotDTOTest()
        {
            weatherBot = fixture.Create<WeatherBotDTO>();
            weatherState = fixture.Create<WeatherStateDTO>();
            weatherBot.TemperatureUnderThreshold = weatherBot.TemperatureAboveThreshold - 2;
        }

        [Fact]
        public void ThresholdsShouldNotBeTriggered()
        {
            // Act
            weatherState.Temperature = (float)weatherBot.TemperatureAboveThreshold - 1;
            weatherState.Humidity = (float)weatherBot.HumidityThreshold - 1;
            weatherBot.CheckThresholds(weatherState);

            // Assert
            weatherBot.IsThresholdTriggered.Should().BeFalse();
        }

        [Fact]
        public void HumidityThresholdShouldBeTriggered()
        {
            // Act
            weatherState.Temperature = (float)weatherBot.TemperatureAboveThreshold - 1;
            weatherState.Humidity = (float)weatherBot.HumidityThreshold + 1;
            weatherBot.CheckThresholds(weatherState);

            // Assert
            weatherBot.IsThresholdTriggered.Should().BeTrue();
        }

        [Fact]
        public void TemperatureAboveThresholdShouldBeTriggered()
        {
            // Act
            weatherState.Temperature = (float)weatherBot.TemperatureAboveThreshold + 1;
            weatherState.Humidity = (float)weatherBot.HumidityThreshold - 1;
            weatherBot.CheckThresholds(weatherState);

            // Assert
            weatherBot.IsThresholdTriggered.Should().BeTrue();
        }

        [Fact]
        public void TemperatureUnderThresholdShouldBeTriggered()
        {
            // Act
            weatherState.Temperature = (float)weatherBot.TemperatureUnderThreshold - 1;
            weatherState.Humidity = (float)weatherBot.HumidityThreshold - 1;
            weatherBot.CheckThresholds(weatherState);

            // Assert
            weatherBot.IsThresholdTriggered.Should().BeTrue();
        }
    }
}