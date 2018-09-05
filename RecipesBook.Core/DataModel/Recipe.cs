using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace RecipesBook.Core.DataModel
{
    public class Recipe
    {
           
        [JsonProperty (PropertyName = "method")]
        private string method;
        public string Method { get => method; set => method = value; }

        [JsonProperty(PropertyName = "ingredients")]
        private string ingredientsText;
        public string IngredientsText { get => ingredientsText; set => ingredientsText = value; }

        [JsonProperty (PropertyName = "name")]
        private string name;
        public string Name { get => name; set => name = value; }

        [JsonProperty (PropertyName = "duration")]
        private string duration;
        public string Duration { get => duration; set => duration = value; }

        [JsonProperty (PropertyName = "difficulty")]
        private string difficulty;
        public string Difficulty { get => difficulty; set => difficulty = value; }

        private byte[] image;
        public byte[] Image { get => image; set => image = value; }

        [JsonProperty(PropertyName = "image")]
        private string imageUrl;
        public string ImageUrl { get => imageUrl; set => imageUrl = value; }

    }
}
