﻿using DeltaDriveBE.DTO.AuthDTO;
using DeltaDriveBE.DTO.PassengerDTO;

namespace DeltaDriveBE.Interfaces
{
    public interface IPassengerService
    {
        LoginPassengerResponseDTO LoginUser(LoginPassengerRequestDTO requestDTO);
        RegisterPassengerResponseDTO RegisterUser(RegisterPassengerRequestDTO requestDTO);
        string GetClosestDrivers(int amount, float latitude, float longitude);
        string GetDriverRating(Guid id);
        PassengerResponseDTO GetUserById(Guid id);
    }
}
