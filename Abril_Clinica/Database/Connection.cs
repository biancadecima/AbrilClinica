using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Google.Cloud.Firestore.V1.StructuredQuery.Types;

namespace AbrilClinica.Entities.Database
{
    public class Connection
    {
        private string _collection;
        private string _document;

        public Connection(string collection, string document)
        {
            _collection = collection;
            _document = document;
        }

        public static async Task AddAsync(object item, string collection) // recibe como parametro un objeto personalizado Firestore
        {
            var projectId = "abril-clinica-database";
            FirestoreDb db = FirestoreDb.Create(projectId);
            var colRef = db.Collection(collection);
            //Dictionary<string, object> item =
            //colRef.AddAsync(item);// como parametro le paso un diccionario
            //Dictionary<string, object> data = new Dictionary<string, object>
            //{
            //    item
            //};
            await colRef.AddAsync(item); 



            /*var doc = await docRef.GetSnapshotAsync(); */// devuelve una actualizacion del documento
            //al ser asincronico no sabemos cuando vuelve
            // await permite la ejecuion del programa  y mientras espera que el async decuelva una respuesta
            // el sincronico, en cambio, clava la ejecucion del programa esperando una respuesta
        }

        public static async Task UpdateAsync(object item, string collection)
        {
            var projectId = "abril-clinica-database"; // tengo que crear un proyecto en cada funcion?
            FirestoreDb db = FirestoreDb.Create(projectId);
            var colRef = db.Collection(collection);
           // await colRef.SetAsync(item);

        }

        public static async Task/*<List<Object>>*/ GetAllAsync(string collection)
        {
            var projectId = "abril-clinica-database";
            FirestoreDb db = FirestoreDb.Create(projectId);
            var colRef = db.Collection(""); // nombre de la coleccion (la puedo traer por parametro)
            var snapshot = await colRef.GetSnapshotAsync();
            var items = new List<Object>();
            foreach (var item in snapshot.Documents)
            {
                //Object obj = snapshot.ConvertTo<Object>();
                items.Add(item);
                Console.WriteLine(item);
            }

            //return items;

            //var projectId = "abril-clinica-database"; // tengo que crear un proyecto en cada funcion?
            //FirestoreDb db = FirestoreDb.Create(projectId);
            //Query allItemsQuery = db.Collection(collection);
            //QuerySnapshot allItemsQuerySnapshot = await allItemsQuery.GetSnapshotAsync();
            //foreach (DocumentSnapshot documentSnapshot in allItemsQuerySnapshot.Documents)
            //{
            //    //Console.WriteLine("Document data for {0} document:", documentSnapshot.Id);
            //    Dictionary<string, object> city = documentSnapshot.ToDictionary();
            //    foreach (KeyValuePair<string, object> pair in city)
            //    {
            //        Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
            //    }
            //    //Console.WriteLine("");
            //}


        }
    }
}
