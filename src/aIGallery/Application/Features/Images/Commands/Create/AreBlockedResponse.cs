using Core.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Images.Commands.Create;
public class AreBlockedResponse : IResponse
{
    public bool status { get; set; }
}
