using System.Reflection.Metadata.Ecma335;
using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.DeviceDtos;
using TrialsSystem.UsersService.Infrastructure.Models.UserDTOs;

namespace TrialsSystem.UsersService.Api.Application.Commands.DeviceCommands
{
    public class UpdateDeviceCommandHandler : IRequestHandler<UpdateDeviceCommand, DeviceResponse>
    {
        public async Task<DeviceResponse> Handle(UpdateDeviceCommand request, CancellationToken cancellationToken)
        {
            return new DeviceResponse();
        }
    }
}
