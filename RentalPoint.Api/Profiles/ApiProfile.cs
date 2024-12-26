using AutoMapper;
using TicketBookingApplication.Api.Dto;
using TicketBookingApplication.Api.Models;

namespace TicketBookingApplication.Api.Profiles
{
    public class ApiProfile : Profile
    {
        public ApiProfile() 
        {
            CreateMap<Movie, MovieRequest>()
                .ReverseMap();
            CreateMap<Movie, MovieResponse>()
                .ReverseMap();

            CreateMap<Genre, GenreRequest>()
                .ReverseMap();
            CreateMap<Genre, GenreResponse>()
                .ReverseMap();

            CreateMap<Client, ClientRequest>()
                .ReverseMap();
            CreateMap<Client, ClientResponse>()
                .ReverseMap();

            CreateMap<Ticket, TicketRequest>()
                .ReverseMap();
            CreateMap<Ticket, TicketResponse>()
                .ReverseMap();

            CreateMap<Session, SessionRequest>()
                .ReverseMap();
            CreateMap<Session, SessionResponse>()
                .ReverseMap();
            CreateMap<Session, SessionMovieResponse>()
                .ReverseMap();
        }
    }
}
