using DiscordRPC;
using DiscordRPC.Events;
using DiscordRPC.Logging;
using DiscordRPC.Message;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elegant_Studio.Araclar
{
    public class DiscordRich
    {
		public static DiscordRpcClient client;

		public static DateTime bastm;

		public static void Initialize(string projeadi, string dosyaadi)
		{
			bastm = DateTime.UtcNow;

			client = new DiscordRpcClient("793436434903990304");

			client.Initialize();

			client.SetPresence(new RichPresence()
			{
				Details = projeadi,
				State = dosyaadi,
				Assets = new Assets()
				{
					LargeImageKey = "csharp",
					LargeImageText = "C#",
					SmallImageKey = "elegant",
					SmallImageText = "Elegant Studio 2021"
				},

				Timestamps = new Timestamps()
				{
					Start = bastm
				}
			});
		}

		public static void guncelle(string projeadi, string dosyaadi)
        {
			client.SetPresence(new RichPresence()
			{
				Details = projeadi,
				State = dosyaadi,
				Assets = new Assets()
				{
					LargeImageKey = "csharp",
					LargeImageText = "C#",
					SmallImageKey = "elegant",
					SmallImageText = "Elegant Studio 2021"
				},

				Timestamps = new Timestamps()
				{
					Start = bastm
				}
			});
		}

		private static Random random = new Random();

		public static string RandomString(int length)
		{
			const string chars = "abcdefghijklmnopqrstuvyzwxABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
			return new string(Enumerable.Repeat(chars, length)
			  .Select(s => s[random.Next(s.Length)]).ToArray());
		}

		public static void joinrq(object sender, JoinRequestMessage msg)
        {
			DiscordRpcClient client = (DiscordRpcClient)sender;
			client.Respond(msg, true);
		}

		private static void OnJoin(object sender, JoinMessage args)
		{
			Process.Start(Path.Combine(ProgramFilesx86(), "Antares Enterprise", "Elegant Studio", "elegant.exe"), args.Secret);
		}

		public static void partiac(string key)
        {
			client.RegisterUriScheme(
				steamAppID: null,
				executable: Path.Combine(ProgramFilesx86(), "Antares Enterprise", "Elegant Studio", "elegant.exe")
			);

			client.UpdateParty(new Party()
			{
				ID = "ElegantStudio",
				Size = 1,
				Max = 100,
				Privacy = Party.PrivacySetting.Public
			});

			client.UpdateSecrets(new Secrets()
			{
				JoinSecret = key
			});
		}

		static string ProgramFilesx86()
		{
			if (8 == IntPtr.Size
				|| (!String.IsNullOrEmpty(Environment.GetEnvironmentVariable("PROCESSOR_ARCHITEW6432"))))
			{
				return Environment.GetEnvironmentVariable("ProgramFiles(x86)");
			}

			return Environment.GetEnvironmentVariable("ProgramFiles");
		}
	}
}
