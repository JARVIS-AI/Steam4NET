// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;
using Steam4NET.Attributes;

namespace Steam4NET
{

	[InterfaceVersion("CLIENTDEPOTBUILDER_INTERFACE_VERSION001")]
	public interface IClientProductBuilder
	{
		[VTableSlot(0)]
		UInt64 SignInstallScript(UInt32 arg0, string arg1, string arg2);
		[VTableSlot(1)]
		UInt64 DRMWrap(UInt32 arg0, string arg1, string arg2, string arg3, UInt32 arg4);
		[VTableSlot(2)]
		UInt64 CEGWrap(UInt32 arg0, string arg1, string arg2, string arg3);
	};
}