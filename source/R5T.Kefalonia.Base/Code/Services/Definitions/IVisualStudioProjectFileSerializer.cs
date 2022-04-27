using System;

using R5T.D0013; // IFileSerializer<T>
using R5T.Gloucester.Types;using R5T.T0064;


namespace R5T.Kefalonia
{[ServiceDefinitionMarker]
    public interface IVisualStudioProjectFileSerializer : IFileSerializer<ProjectFile>,IServiceDefinition
    {
    }
}
