namespace dotnet_rpg.Controllers.Services.CharacterService
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using dotnet_rpg.Models;
    public interface ICharacterService
    {
        Task<List<Character>> GetAllCharacters();
        Task<Character> GetCharacterById(int id);
        Task<List<Character>> AddCharacter(Character newCharacter);
    }
}