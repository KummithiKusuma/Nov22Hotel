﻿using HotelBookingApp.Models.DTOs;

namespace HotelBookingAPP.Interfaces
{
    public interface ITokenService
    {
        /// <summary>
        /// It is used for generating token for user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>

        string GetToken(UserDTO user);
    }
}