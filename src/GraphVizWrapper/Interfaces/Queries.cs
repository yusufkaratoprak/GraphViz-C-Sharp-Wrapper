﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Queries.cs" company="Jamie Dixon Ltd">
//   Jamie Dixon
// </copyright>
// <summary>
//   Defines the GraphVizWrapper type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GraphVizWrapper.Interfaces
{
    using System.Diagnostics;

    
    public interface IGetProcessStartInfoQuery : IQuery<IProcessStartInfoWrapper, ProcessStartInfo> { }
}
