using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Azure.Documents.Client;
using Microsoft.Azure.Documents.Linq;
using RecipesBook.Core.DataModel;

namespace RecipesBook.Core
{
    public class RecipesManager : IRecipesManager
    {
        const string databaseId = @"RecipesDB";
        const string collectionId = @"Recipes";

        private Uri collectionLink = UriFactory.CreateDocumentCollectionUri(databaseId, collectionId);

        private DocumentClient client;

        public RecipesManager()
        {
            client = new DocumentClient(new System.Uri(ApiKeys.accountURL), ApiKeys.accountKey);
        }

        public List<Recipe> Recipes { get; private set; }

        public async Task<List<Recipe>> GetRecipesAsync()
        {
            try
            {
                var query = client.CreateDocumentQuery<Recipe>(collectionLink, new FeedOptions { MaxItemCount = -1 }).AsDocumentQuery();

                Recipes = new List<Recipe>();
                while (query.HasMoreResults)
                {
                    Recipes.AddRange(await query.ExecuteNextAsync<Recipe>());
                }


            }
            catch (Exception e)
            {
                Console.Error.WriteLine(@"ERROR {0}", e.Message);
                return null;
            }

            return Recipes;
        }

    }

    public interface IRecipesManager
    {
        Task<List<Recipe>> GetRecipesAsync();
    }
}
