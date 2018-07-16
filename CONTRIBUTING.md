## Contributors:

As a contributor you can directly commit to the project. Please create a new branch for everything, and then submit pull-request. This is done easily right here on the page if you're not awesome enough in the CLI.

Clone the SharpCast_TV repository recursively (forking will also work):
* Nuke your nuget cache `rm -rf ~/.nuget/packages/newtonsoft.json*` (Bing/Google the location for windows...)

1. Create a new branch. This can be done easily on github. [e.g.](https://i.imgur.com/EDtnZ56.png)
  1. Naming convention: `<type of branch>-<name of your contribution>` where
    * `<type of branch>` is generally either `feature`, `improvement` or `fix` (similar to issue labels)
    * `<name of your contribution>` would e whatever your code is going to be about, where it should use camelCase. In case of an issue, just add the ticket number.
  2. Examples:
    * `feature-commandOverrides` (without an issue)
    * `improvement-123-youtubeNotifications` (for issue `#123`)
    * `fix-123` (for issue `#123`) _Please don't use **just** the number for bigger features, add some title to know what's that about without having to look it up._
2. Commit your code properly into your branch as you work on it.
  1. Recommended IDE to write your code
  	* [Visual Studio](https://visualstudio.microsoft.com/vs/) - Windows + Mac - lead developer uses this
    * [Visual Studio Code](https://code.visualstudio.com) - Windows, Linux and Mac. Preferred choice for Linux users.
  2. Follow our naming conventions and code style guide below. (Set up your IDE for it...)
3. Test your code.
4. Submit PullRequest when you're done. This can be done easily on github. e.g. [1.](https://i.imgur.com/vF1uSMm.png) [2.](https://i.imgur.com/mbNvr3c.png)
  1. New features or improvements or any other large changes should go into the `dev` branch.
  2. Really tiny fixes and typos, or tiny improvements of a response message, etc, can go straight into `master`. If in doubt ask.
  3. If there is an issue for your PR, make sure to mention the `#number` in the title.

### Outside contributors:

The workflow for outside contribution is recommended to be the same, we don't bite :P

The only difference is that you would first fork the repository, then follow all the other stuff and eventually submit a PR from your fork, into our appropriate branch.

## Code style and Naming Conventions

Just a few guidelines about the code:

* If you're writing a new module, try to write summary for public and internal methods.
* Use PascalCase for public member properties and `this` notation for private ones. Treat internal as public, and protected as private. Treat constants as public as well, ie PascalCase.
* Always immediately initialise variables.
* Always explicitly declare whether methods are public or private. If they are async, this keyword should be second (or third in case of static methods `public static async Task ...`)
* Never return `void` with async methods unless you know what you're doing. Return `Task` instead of `void`.
* Our current namespace is `SharpCast`
* Please see below for our writing style

```cs
namespace SharpCast
{
    public class TotalViews
    {
        [JsonProperty("total_live_views")]
        public string TotalLiveViews { get; set; }
    }
}
```

```cs
  namespace SharpCast
{
    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();

        internal class ParseIntegerConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                long l;
                if (Int64.TryParse(value, out l))
                {
                    return l;
                }
                throw new Exception("Cannot unmarshal type long");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (long)untypedValue;
                serializer.Serialize(writer, value.ToString());
                return;
            }

            public static readonly ParseIntegerConverter Singleton = new ParseIntegerConverter();
        }
    }
}
```

Please try to set-up your IDE to handle this for you:

* Use tabs, do not expand to spaces.
* **Always** use explicit types. **Do Not Use `var`!**
* Set the IDE to remove trailing whitespace

