namespace dotnet_rpg.Controllers.Services.CharacterService
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using dotnet_rpg.Models;
    public interface ICharacterService
    {
        Task<ServiceResponse<List<Character>>> GetAllCharacters();
        Task<ServiceResponse<Character>> GetCharacterById(int id);
        Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter);
    }
}