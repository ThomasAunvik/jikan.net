﻿using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace JikanDotNet.Tests
{
	public class CharacterTestClass
	{
		private readonly IJikan jikan;

		public CharacterTestClass()
		{
			jikan = new Jikan(true);
		}

		[Theory]
		[InlineData(1)]
		[InlineData(2)]
		[InlineData(3)]
		public async Task GetCharacter_CorrectId_ShouldReturnNotNullCharacter(long malId)
		{
			Character returnedCharacter = await jikan.GetCharacter(malId);

			Assert.NotNull(returnedCharacter);
		}

		[Theory]
		[InlineData(8)]
		[InlineData(9)]
		[InlineData(10)]
		public async Task GetCharacter_WrongId_ShouldReturnNullCharacter(long malId)
		{
			Character returnedCharacter = await jikan.GetCharacter(malId);

			Assert.Null(returnedCharacter);
		}

		[Fact]
		public async Task GetCharacter_IchigoKurosakiId_ShouldParseIchigoKurosaki()
		{
			Character ichigo = await jikan.GetCharacter(5);

			Assert.Equal("Ichigo Kurosaki", ichigo.Name);
		}

		[Fact]
		public async Task GetCharacter_IchigoKurosakiId_ShouldParseIchigoKurosakiBleach()
		{
			Character ichigo = await jikan.GetCharacter(5);

			Assert.Contains("Bleach", ichigo.Animeography.Select(x => x.Name));
			Assert.Contains("Bleach", ichigo.Mangaography.Select(x => x.Name));
		}

		[Fact]
		public async Task GetCharacter_EinId_ShouldParseEin()
		{
			Character ein = await jikan.GetCharacter(4);

			Assert.Equal("Ein", ein.Name);

			Assert.Equal("Supporting", ein.Animeography.First().Role);
			Assert.Equal("Supporting", ein.Mangaography.First().Role);
			Assert.Equal("Main", ein.Animeography.Last().Role);
		}
	}
}