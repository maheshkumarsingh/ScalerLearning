﻿using ServiceContracts.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Strategies.PersonSearchStrategy
{
    public class PersonSearchStrategyFactory
    {
        public static IPersonSearchStrategy GetSearchPersonStrategy(string searchBy)
        {
            switch (searchBy)
            {
                case nameof(PersonResponseDTO.PersonName):
                    return new PersonSearchByNameStrategy();
                case nameof(PersonResponseDTO.Email):
                    return new PersonSearchByEmailStrategy();
                case nameof(PersonResponseDTO.DOB):
                    return new PersonSearchByDOBStrategy();
                case nameof(PersonResponseDTO.Gender):
                    return new PersonSearchByGenderStrategy();
                case nameof(PersonResponseDTO.Address):
                    return new PersonSearchByAddressStrategy();
                case nameof(PersonResponseDTO.CountryID):
                    return new PersonSearchByCountryIDStrategy();
            }
            return null;
        }
    }
}
