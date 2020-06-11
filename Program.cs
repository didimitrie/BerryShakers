using System;
using System.Threading.Tasks;
using StrawberryShake;
using StrawberryShake.Serializers;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;


namespace BerryClient
{
  class Program
  {
    static async Task Main(string[] args)
    {
      var serviceCollection = new ServiceCollection();
      var token = "e90c8db18d0a5175877bd106105fa0806bba36e621";

      serviceCollection.AddHttpClient("SpeckleClient", c =>
      {
        c.BaseAddress = new Uri("http://localhost:3000/graphql");
        c.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
      });
      serviceCollection.AddSpeckleClient();
      serviceCollection.AddSingleton<IValueSerializer, JSONObjectSerializer>();

      IServiceProvider services = serviceCollection.BuildServiceProvider();
      


      ISpeckleClient client = services.GetRequiredService<ISpeckleClient>();

      IOperationResult<IGetServerInfo> result = await client.GetServerInfoAsync();
      Console.WriteLine(result.Data.ServerInfo.Name);
      Console.WriteLine(result.Data.ServerInfo.Company);
      Console.WriteLine(result.Data.ServerInfo.TermsOfService);
      Console.WriteLine(string.Join(", ", result.Data.ServerInfo.Roles.Select( role => role.Name).ToArray()));

      var myProfile = await client.GetMyProfileAsync();
      Console.WriteLine(myProfile.Data.User.Name);
      Console.WriteLine(myProfile.Data.User.Id);
      Console.WriteLine(myProfile.Data.User.Email);

      var testStream = await client.GetStreamAsync("154eaa6a1b");
      Console.WriteLine(testStream.Data.Stream.Name);
      Console.WriteLine(testStream.Data.Stream.Commits.TotalCount);

    }
  }

  public class JSONObjectSerializer : ValueSerializerBase<String, String>
  {
    public override string Name => "JSONObject";

    public override ValueKind Kind => ValueKind.String;
    public override object? Serialize(object? value)
    {
      if (value is null)
      {
        return null;
      }

      if (value is string s)
      {
        return s;
      }

      throw new ArgumentException(
          "The specified value is of an invalid type. " +
          $"{ClrType.FullName} was expeceted.");
    }

    public override object? Deserialize(object? serialized)
    {
      if (serialized is null)
      {
        return null;
      }

      if (serialized is string s)
      {
        return s;
      }

      throw new ArgumentException(
          "The specified value is of an invalid type. " +
          $"{SerializationType.FullName} was expeceted.");
    }

  }
}
