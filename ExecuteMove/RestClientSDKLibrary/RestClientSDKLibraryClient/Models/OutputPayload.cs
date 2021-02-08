﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace RestClientSDKLibrary.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    public partial class OutputPayload
    {
        /// <summary>
        /// Initializes a new instance of the OutputPayload class.
        /// </summary>
        public OutputPayload() { }

        /// <summary>
        /// Initializes a new instance of the OutputPayload class.
        /// </summary>
        public OutputPayload(int? move = default(int?), string azurePlayerSymbol = default(string), string humanPlayerSymbol = default(string), string winner = default(string), IList<string> winPositions = default(IList<string>), IList<string> gameBoard = default(IList<string>), string message = default(string))
        {
            Move = move;
            AzurePlayerSymbol = azurePlayerSymbol;
            HumanPlayerSymbol = humanPlayerSymbol;
            Winner = winner;
            WinPositions = winPositions;
            GameBoard = gameBoard;
            Message = message;
        }

        /// <summary>
        /// Example renaming a property using JsonProperyName
        /// </summary>
        [JsonProperty(PropertyName = "move")]
        public int? Move { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "azurePlayerSymbol")]
        public string AzurePlayerSymbol { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "humanPlayerSymbol")]
        public string HumanPlayerSymbol { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "winner")]
        public string Winner { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "winPositions")]
        public IList<string> WinPositions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gameBoard")]
        public IList<string> GameBoard { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

    }
}
