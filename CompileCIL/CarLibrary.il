
//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.8.3928.0
//  Copyright (c) Microsoft Corporation.  All rights reserved.


// ----- DOS Header:
// Magic:                      0x5a4d
// Bytes on last page:         0x0090
// Pages in file:              0x0003
// Relocations:                0x0000
// Size of header (paragraphs):0x0004
// Min extra paragraphs:       0x0000
// Max extra paragraphs:       0xffff
// Initial (relative) SS:      0x0000
// Initial SP:                 0x00b8
// Checksum:                   0x0000
// Initial IP:                 0x0000
// Initial (relative) CS:      0x0000
// File addr. of reloc table:  0x0040
// Overlay number:             0x0000
// OEM identifier:             0x0000
// OEM info:                   0x0000
// File addr. of COFF header:  0x0080
// ----- COFF/PE Headers:
// Signature:                  0x00004550
// ----- COFF Header:
// Machine:                    0x014c
// Number of sections:         0x0003
// Time-date stamp:            0x91147364
// Ptr to symbol table:        0x00000000
// Number of symbols:          0x00000000
// Size of optional header:    0x00e0
// Characteristics:            0x0022
// ----- PE Optional Header (32 bit):
// Magic:                          0x010b
// Major linker version:           0x30
// Minor linker version:           0x00
// Size of code:                   0x00000c00
// Size of init.data:              0x00000800
// Size of uninit.data:            0x00000000
// Addr. of entry point:           0x00002bea
// Base of code:                   0x00002000
// Base of data:                   0x00004000
// Image base:                     0x00400000
// Section alignment:              0x00002000
// File alignment:                 0x00000200
// Major OS version:               0x0004
// Minor OS version:               0x0000
// Major image version:            0x0000
// Minor image version:            0x0000
// Major subsystem version:        0x0004
// Minor subsystem version:        0x0000
// Size of image:                  0x00008000
// Size of headers:                0x00000200
// Checksum:                       0x00000000
// Subsystem:                      0x0003
// DLL characteristics:            0x8560
// Size of stack reserve:          0x00100000
// Size of stack commit:           0x00001000
// Size of heap reserve:           0x00100000
// Size of heap commit:            0x00001000
// Loader flags:                   0x00000000
// Directories:                    0x00000010
// 0x00000000 [0x00000000] address [size] of Export Directory:          
// 0x00002b96 [0x0000004f] address [size] of Import Directory:          
// 0x00004000 [0x000005b8] address [size] of Resource Directory:        
// 0x00000000 [0x00000000] address [size] of Exception Directory:       
// 0x00000000 [0x00000000] address [size] of Security Directory:        
// 0x00006000 [0x0000000c] address [size] of Base Relocation Table:     
// 0x00002aac [0x00000054] address [size] of Debug Directory:           
// 0x00000000 [0x00000000] address [size] of Architecture Specific:     
// 0x00000000 [0x00000000] address [size] of Global Pointer:            
// 0x00000000 [0x00000000] address [size] of TLS Directory:             
// 0x00000000 [0x00000000] address [size] of Load Config Directory:     
// 0x00000000 [0x00000000] address [size] of Bound Import Directory:    
// 0x00002000 [0x00000008] address [size] of Import Address Table:      
// 0x00000000 [0x00000000] address [size] of Delay Load IAT:            
// 0x00002008 [0x00000048] address [size] of CLR Header:                


// Image sections:
//              .text
//              0x00000bf0 Virtual Size
//              0x00002000 Virtual Address
//              0x00000c00 Size of Raw Data
//              0x00000200 Pointer to Raw Data
//              0x00000000 Pointer to Relocations
//              0x00000000 Pointer to Linenumbers
//                  0x0000 Number of Relocations
//                  0x0000 Number of Linenumbers
//              0x60000020 Characteristics
//                         CNT_CODE
//                         MEM_EXECUTE
//                         MEM_READ

//              .rsrc
//              0x000005b8 Virtual Size
//              0x00004000 Virtual Address
//              0x00000600 Size of Raw Data
//              0x00000e00 Pointer to Raw Data
//              0x00000000 Pointer to Relocations
//              0x00000000 Pointer to Linenumbers
//                  0x0000 Number of Relocations
//                  0x0000 Number of Linenumbers
//              0x40000040 Characteristics
//                         CNT_INITIALIZED_DATA
//                         MEM_READ

//              .reloc
//              0x0000000c Virtual Size
//              0x00006000 Virtual Address
//              0x00000200 Size of Raw Data
//              0x00001400 Pointer to Raw Data
//              0x00000000 Pointer to Relocations
//              0x00000000 Pointer to Linenumbers
//                  0x0000 Number of Relocations
//                  0x0000 Number of Linenumbers
//              0x42000040 Characteristics
//                         CNT_INITIALIZED_DATA
//                         MEM_DISCARDABLE
//                         MEM_READ

// Base Relocation Table
//              0x00002000 Page RVA
//              0x0000000c Block Size
//              0x00000002 Number of Entries
//              Entry 1: Type 0x3 Offset 0x00000bec
//              Entry 2: Type 0x0 Offset 0x00000000

// Import Address Table
//     DLL : mscoree.dll
//              0x00002000 Import Address Table
//              0x00002bd8 Import Name Table
//              0          Time Date Stamp
//              0          Index of First Forwarder Reference
//
//              0x0000  _CorExeMain

// Delay Load Import Address Table
// No data.

// Entry point code:
//FF 25 00 20 40 00 


// ----- CLR Header:
// Header size:                        0x00000048
// Major runtime version:              0x0002
// Minor runtime version:              0x0005
// 0x00002158 [0x00000954] address [size] of Metadata Directory:        
// Flags:                              0x00000001
// Entry point token:                  0x06000001
// 0x00000000 [0x00000000] address [size] of Resources Directory:       
// 0x00000000 [0x00000000] address [size] of Strong Name Signature:     
// 0x00000000 [0x00000000] address [size] of CodeManager Table:         
// 0x00000000 [0x00000000] address [size] of VTableFixups Directory:    
// 0x00000000 [0x00000000] address [size] of Export Address Table:      
// 0x00000000 [0x00000000] address [size] of Precompile Header:         

// Metadata Header
//    Storage Signature:
//              0x424a5342 Signature
//                  0x0001 Major Version
//                  0x0001 Minor Version
//              0x00000000 Extra Data Offset
//              0x0000000c Version String Length
//              'v4.0.30319' Version String
//    Storage Header:
//                    0x00 Flags
//                  0x0005 Number of Streams
//    Stream 1:
//              0x0000006c Offset
//              0x00000344 Size
//              '#~' Name
//    Stream 2:
//              0x000003b0 Offset
//              0x00000340 Size
//              '#Strings' Name
//    Stream 3:
//              0x000006f0 Offset
//              0x00000104 Size
//              '#US' Name
//    Stream 4:
//              0x000007f4 Offset
//              0x00000010 Size
//              '#GUID' Name
//    Stream 5:
//              0x00000804 Offset
//              0x00000150 Size
//              '#Blob' Name

//    Metadata Stream Header:
//              0x00000000 Reserved
//                    0x02 Major
//                    0x00 Minor
//                    0x00 Heaps
//                    0x01 Rid
//      0x0000000901a21557 MaskValid
//      0x000016003301fa00 Sorted

// Code Manager Table:
//  default


// Export Address Table Jumps:
// No data.

// File size            : 5632
// PE header size       : 512 (496 used)    ( 9.09%)
// PE additional info   : 1719              (30.52%)
// Num.of PE sections   : 3
// CLR header size     : 72                 ( 1.28%)
// CLR meta-data size  : 2388               (42.40%)
// CLR additional info : 0                  ( 0.00%)
// CLR method headers  : 21                 ( 0.37%)
// Managed code         : 241               ( 4.28%)
// Data                 : 2048              (36.36%)
// Unaccounted          : -1369             (-24.31%)

// Num.of PE sections   : 3
//   .text    - 3072
//   .rsrc    - 1536
//   .reloc   - 512

// CLR meta-data size  : 2388
//   Module        -    1 (10 bytes)
//   TypeDef       -    3 (42 bytes)      0 interfaces, 0 explicit layout
//   TypeRef       -   20 (120 bytes)
//   MethodDef     -   10 (140 bytes)     0 abstract, 0 native, 10 bodies
//   FieldDef      -    3 (18 bytes)      0 constant
//   MemberRef     -   20 (120 bytes)
//   ParamDef      -    4 (24 bytes)
//   CustomAttribute-   26 (156 bytes)
//   StandAloneSig -    1 (2 bytes)
//   PropertyMap   -    1 (4 bytes)
//   Property      -    3 (18 bytes)
//   MethodSemantic-    6 (36 bytes)
//   Assembly      -    1 (22 bytes)
//   AssemblyRef   -    2 (40 bytes)
//   Strings       -   832 bytes
//   Blobs         -   336 bytes
//   UserStrings   -   260 bytes
//   Guids         -    16 bytes
//   Uncategorized -   192 bytes

// CLR method headers : 21
//   Num.of method bodies  - 10
//   Num.of fat headers    - 1
//   Num.of tiny headers   - 9

// Managed code : 241
//   Ave method size - 24
// Classes defined in this module:
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// Class Program                        (auto) (ansi) 
// Class Car                            (public) (auto) (ansi) 
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

// ================================= M E T A I N F O ================================================

// ===========================================================
// ScopeName : CarLibrary.dll
// MVID      : {7ADE1A94-BAF6-4314-9836-1DBC7C53D94C}
// 	CustomAttribute #1 (0c000003)
// 	-------------------------------------------------------
// 		CustomAttribute Type: 0a00000b
// 		CustomAttributeName: System.Runtime.CompilerServices.RefSafetyRulesAttribute :: instance void .ctor(int32)
// 		Length: 8
// 		Value : 01 00 0b 00 00 00 00 00                          >                <
// 		ctor args: (11)
// 
// ===========================================================
// Global functions
// -------------------------------------------------------
// 
// Global fields
// -------------------------------------------------------
// 
// Global MemberRefs
// -------------------------------------------------------
// 
// TypeDef #1 (02000002)
// -------------------------------------------------------
// 	TypDefName: Program  (02000002)
// 	Flags     : [NotPublic] [AutoLayout] [Class] [AnsiClass] [BeforeFieldInit]  (00100000)
// 	Extends   : 0100000E [TypeRef] System.Object
// 	Method #1 (06000001) [ENTRYPOINT]
// 	-------------------------------------------------------
// 		MethodName: <Main>$ (06000001)
// 		Flags     : [Private] [Static] [HideBySig] [ReuseSlot]  (00000091)
// 		RVA       : 0x00002050
// 		ImplFlags : [IL] [Managed]  (00000000)
// 		CallCnvntn: [DEFAULT]
// 		ReturnType: Void
// 		1 Arguments
// 			Argument #1:  SZArray String
// 		1 Parameters
// 			(1) ParamToken : (08000001) Name : args flags: [none] (00000000)
// 
// 	Method #2 (06000002) 
// 	-------------------------------------------------------
// 		MethodName: .ctor (06000002)
// 		Flags     : [Public] [HideBySig] [ReuseSlot] [SpecialName] [RTSpecialName] [.ctor]  (00001886)
// 		RVA       : 0x00002103
// 		ImplFlags : [IL] [Managed]  (00000000)
// 		CallCnvntn: [DEFAULT]
// 		hasThis 
// 		ReturnType: Void
// 		No arguments.
// 
// 	CustomAttribute #1 (0c000010)
// 	-------------------------------------------------------
// 		CustomAttribute Type: 0a00000c
// 		CustomAttributeName: System.Runtime.CompilerServices.CompilerGeneratedAttribute :: instance void .ctor()
// 		Length: 4
// 		Value : 01 00 00 00                                      >                <
// 		ctor args: ()
// 
// 
// TypeDef #2 (02000003)
// -------------------------------------------------------
// 	TypDefName: CarLibrary.Car  (02000003)
// 	Flags     : [Public] [AutoLayout] [Class] [AnsiClass] [BeforeFieldInit]  (00100001)
// 	Extends   : 0100000E [TypeRef] System.Object
// 	Field #1 (04000001)
// 	-------------------------------------------------------
// 		Field Name: <Brand>k__BackingField (04000001)
// 		Flags     : [Private]  (00000001)
// 		CallCnvntn: [FIELD]
// 		Field type:  String
// 		CustomAttribute #1 (0c000001)
// 		-------------------------------------------------------
// 			CustomAttribute Type: 0a00000c
// 			CustomAttributeName: System.Runtime.CompilerServices.CompilerGeneratedAttribute :: instance void .ctor()
// 			Length: 4
// 			Value : 01 00 00 00                                      >                <
// 			ctor args: ()
// 
// 		CustomAttribute #2 (0c000002)
// 		-------------------------------------------------------
// 			CustomAttribute Type: 0a00000f
// 			CustomAttributeName: System.Diagnostics.DebuggerBrowsableAttribute :: instance void .ctor(value class System.Diagnostics.DebuggerBrowsableState)
// 			Length: 8
// 			Value : 01 00 00 00 00 00 00 00                          >                <
// 			ctor args: ( <can not decode> )
// 
// 
// 	Field #2 (04000002)
// 	-------------------------------------------------------
// 		Field Name: <Model>k__BackingField (04000002)
// 		Flags     : [Private]  (00000001)
// 		CallCnvntn: [FIELD]
// 		Field type:  String
// 		CustomAttribute #1 (0c00000e)
// 		-------------------------------------------------------
// 			CustomAttribute Type: 0a00000c
// 			CustomAttributeName: System.Runtime.CompilerServices.CompilerGeneratedAttribute :: instance void .ctor()
// 			Length: 4
// 			Value : 01 00 00 00                                      >                <
// 			ctor args: ()
// 
// 		CustomAttribute #2 (0c00000f)
// 		-------------------------------------------------------
// 			CustomAttribute Type: 0a00000f
// 			CustomAttributeName: System.Diagnostics.DebuggerBrowsableAttribute :: instance void .ctor(value class System.Diagnostics.DebuggerBrowsableState)
// 			Length: 8
// 			Value : 01 00 00 00 00 00 00 00                          >                <
// 			ctor args: ( <can not decode> )
// 
// 
// 	Field #3 (04000003)
// 	-------------------------------------------------------
// 		Field Name: <Year>k__BackingField (04000003)
// 		Flags     : [Private]  (00000001)
// 		CallCnvntn: [FIELD]
// 		Field type:  I4
// 		CustomAttribute #1 (0c000012)
// 		-------------------------------------------------------
// 			CustomAttribute Type: 0a00000c
// 			CustomAttributeName: System.Runtime.CompilerServices.CompilerGeneratedAttribute :: instance void .ctor()
// 			Length: 4
// 			Value : 01 00 00 00                                      >                <
// 			ctor args: ()
// 
// 		CustomAttribute #2 (0c000013)
// 		-------------------------------------------------------
// 			CustomAttribute Type: 0a00000f
// 			CustomAttributeName: System.Diagnostics.DebuggerBrowsableAttribute :: instance void .ctor(value class System.Diagnostics.DebuggerBrowsableState)
// 			Length: 8
// 			Value : 01 00 00 00 00 00 00 00                          >                <
// 			ctor args: ( <can not decode> )
// 
// 
// 	Method #1 (06000003) 
// 	-------------------------------------------------------
// 		MethodName: get_Brand (06000003)
// 		Flags     : [Public] [HideBySig] [ReuseSlot] [SpecialName]  (00000886)
// 		RVA       : 0x0000210c
// 		ImplFlags : [IL] [Managed]  (00000000)
// 		CallCnvntn: [DEFAULT]
// 		hasThis 
// 		ReturnType: String
// 		No arguments.
// 		CustomAttribute #1 (0c000011)
// 		-------------------------------------------------------
// 			CustomAttribute Type: 0a00000c
// 			CustomAttributeName: System.Runtime.CompilerServices.CompilerGeneratedAttribute :: instance void .ctor()
// 			Length: 4
// 			Value : 01 00 00 00                                      >                <
// 			ctor args: ()
// 
// 
// 	Method #2 (06000004) 
// 	-------------------------------------------------------
// 		MethodName: set_Brand (06000004)
// 		Flags     : [Public] [HideBySig] [ReuseSlot] [SpecialName]  (00000886)
// 		RVA       : 0x00002114
// 		ImplFlags : [IL] [Managed]  (00000000)
// 		CallCnvntn: [DEFAULT]
// 		hasThis 
// 		ReturnType: Void
// 		1 Arguments
// 			Argument #1:  String
// 		1 Parameters
// 			(1) ParamToken : (08000002) Name : value flags: [none] (00000000)
// 		CustomAttribute #1 (0c000016)
// 		-------------------------------------------------------
// 			CustomAttribute Type: 0a00000c
// 			CustomAttributeName: System.Runtime.CompilerServices.CompilerGeneratedAttribute :: instance void .ctor()
// 			Length: 4
// 			Value : 01 00 00 00                                      >                <
// 			ctor args: ()
// 
// 
// 	Method #3 (06000005) 
// 	-------------------------------------------------------
// 		MethodName: get_Model (06000005)
// 		Flags     : [Public] [HideBySig] [ReuseSlot] [SpecialName]  (00000886)
// 		RVA       : 0x0000211d
// 		ImplFlags : [IL] [Managed]  (00000000)
// 		CallCnvntn: [DEFAULT]
// 		hasThis 
// 		ReturnType: String
// 		No arguments.
// 		CustomAttribute #1 (0c000017)
// 		-------------------------------------------------------
// 			CustomAttribute Type: 0a00000c
// 			CustomAttributeName: System.Runtime.CompilerServices.CompilerGeneratedAttribute :: instance void .ctor()
// 			Length: 4
// 			Value : 01 00 00 00                                      >                <
// 			ctor args: ()
// 
// 
// 	Method #4 (06000006) 
// 	-------------------------------------------------------
// 		MethodName: set_Model (06000006)
// 		Flags     : [Public] [HideBySig] [ReuseSlot] [SpecialName]  (00000886)
// 		RVA       : 0x00002125
// 		ImplFlags : [IL] [Managed]  (00000000)
// 		CallCnvntn: [DEFAULT]
// 		hasThis 
// 		ReturnType: Void
// 		1 Arguments
// 			Argument #1:  String
// 		1 Parameters
// 			(1) ParamToken : (08000003) Name : value flags: [none] (00000000)
// 		CustomAttribute #1 (0c000018)
// 		-------------------------------------------------------
// 			CustomAttribute Type: 0a00000c
// 			CustomAttributeName: System.Runtime.CompilerServices.CompilerGeneratedAttribute :: instance void .ctor()
// 			Length: 4
// 			Value : 01 00 00 00                                      >                <
// 			ctor args: ()
// 
// 
// 	Method #5 (06000007) 
// 	-------------------------------------------------------
// 		MethodName: get_Year (06000007)
// 		Flags     : [Public] [HideBySig] [ReuseSlot] [SpecialName]  (00000886)
// 		RVA       : 0x0000212e
// 		ImplFlags : [IL] [Managed]  (00000000)
// 		CallCnvntn: [DEFAULT]
// 		hasThis 
// 		ReturnType: I4
// 		No arguments.
// 		CustomAttribute #1 (0c000019)
// 		-------------------------------------------------------
// 			CustomAttribute Type: 0a00000c
// 			CustomAttributeName: System.Runtime.CompilerServices.CompilerGeneratedAttribute :: instance void .ctor()
// 			Length: 4
// 			Value : 01 00 00 00                                      >                <
// 			ctor args: ()
// 
// 
// 	Method #6 (06000008) 
// 	-------------------------------------------------------
// 		MethodName: set_Year (06000008)
// 		Flags     : [Public] [HideBySig] [ReuseSlot] [SpecialName]  (00000886)
// 		RVA       : 0x00002136
// 		ImplFlags : [IL] [Managed]  (00000000)
// 		CallCnvntn: [DEFAULT]
// 		hasThis 
// 		ReturnType: Void
// 		1 Arguments
// 			Argument #1:  I4
// 		1 Parameters
// 			(1) ParamToken : (08000004) Name : value flags: [none] (00000000)
// 		CustomAttribute #1 (0c00001a)
// 		-------------------------------------------------------
// 			CustomAttribute Type: 0a00000c
// 			CustomAttributeName: System.Runtime.CompilerServices.CompilerGeneratedAttribute :: instance void .ctor()
// 			Length: 4
// 			Value : 01 00 00 00                                      >                <
// 			ctor args: ()
// 
// 
// 	Method #7 (06000009) 
// 	-------------------------------------------------------
// 		MethodName: TurboBoost (06000009)
// 		Flags     : [Public] [HideBySig] [ReuseSlot]  (00000086)
// 		RVA       : 0x0000213f
// 		ImplFlags : [IL] [Managed]  (00000000)
// 		CallCnvntn: [DEFAULT]
// 		hasThis 
// 		ReturnType: Void
// 		No arguments.
// 
// 	Method #8 (0600000a) 
// 	-------------------------------------------------------
// 		MethodName: .ctor (0600000A)
// 		Flags     : [Public] [HideBySig] [ReuseSlot] [SpecialName] [RTSpecialName] [.ctor]  (00001886)
// 		RVA       : 0x0000214d
// 		ImplFlags : [IL] [Managed]  (00000000)
// 		CallCnvntn: [DEFAULT]
// 		hasThis 
// 		ReturnType: Void
// 		No arguments.
// 
// 	Property #1 (17000001)
// 	-------------------------------------------------------
// 		Prop.Name : Brand (17000001)
// 		Flags     : [none] (00000000)
// 		CallCnvntn: [PROPERTY]
// 		hasThis 
// 		ReturnType: String
// 		No arguments.
// 		DefltValue: 
// 		Setter    : (06000004) set_Brand
// 		Getter    : (06000003) get_Brand
// 		0 Others
// 
// 	Property #2 (17000002)
// 	-------------------------------------------------------
// 		Prop.Name : Model (17000002)
// 		Flags     : [none] (00000000)
// 		CallCnvntn: [PROPERTY]
// 		hasThis 
// 		ReturnType: String
// 		No arguments.
// 		DefltValue: 
// 		Setter    : (06000006) set_Model
// 		Getter    : (06000005) get_Model
// 		0 Others
// 
// 	Property #3 (17000003)
// 	-------------------------------------------------------
// 		Prop.Name : Year (17000003)
// 		Flags     : [none] (00000000)
// 		CallCnvntn: [PROPERTY]
// 		hasThis 
// 		ReturnType: I4
// 		No arguments.
// 		DefltValue: 
// 		Setter    : (06000008) set_Year
// 		Getter    : (06000007) get_Year
// 		0 Others
// 
// 	CustomAttribute #1 (0c000014)
// 	-------------------------------------------------------
// 		CustomAttribute Type: 0a00000d
// 		CustomAttributeName: System.Runtime.CompilerServices.NullableContextAttribute :: instance void .ctor(unsigned int8)
// 		Length: 5
// 		Value : 01 00 01 00 00                                   >                <
// 		ctor args: (1)
// 
// 	CustomAttribute #2 (0c000015)
// 	-------------------------------------------------------
// 		CustomAttribute Type: 0a00000e
// 		CustomAttributeName: System.Runtime.CompilerServices.NullableAttribute :: instance void .ctor(unsigned int8)
// 		Length: 5
// 		Value : 01 00 00 00 00                                   >                <
// 		ctor args: (0)
// 
// 
// TypeRef #1 (01000001)
// -------------------------------------------------------
// Token:             0x01000001
// ResolutionScope:   0x23000001
// TypeRefName:       System.Runtime.CompilerServices.CompilationRelaxationsAttribute
// 	MemberRef #1 (0a000001)
// 	-------------------------------------------------------
// 		Member: (0a000001) .ctor: 
// 		CallCnvntn: [DEFAULT]
// 		hasThis 
// 		ReturnType: Void
// 		1 Arguments
// 			Argument #1:  I4
// 
// TypeRef #2 (01000002)
// -------------------------------------------------------
// Token:             0x01000002
// ResolutionScope:   0x23000001
// TypeRefName:       System.Runtime.CompilerServices.RuntimeCompatibilityAttribute
// 	MemberRef #1 (0a000002)
// 	-------------------------------------------------------
// 		Member: (0a000002) .ctor: 
// 		CallCnvntn: [DEFAULT]
// 		hasThis 
// 		ReturnType: Void
// 		No arguments.
// 
// TypeRef #3 (01000003)
// -------------------------------------------------------
// Token:             0x01000003
// ResolutionScope:   0x23000001
// TypeRefName:       System.Diagnostics.DebuggableAttribute
// 	MemberRef #1 (0a000003)
// 	-------------------------------------------------------
// 		Member: (0a000003) .ctor: 
// 		CallCnvntn: [DEFAULT]
// 		hasThis 
// 		ReturnType: Void
// 		1 Arguments
// 			Argument #1:  ValueClass DebuggingModes
// 
// TypeRef #4 (01000004)
// -------------------------------------------------------
// Token:             0x01000004
// ResolutionScope:   0x01000003
// TypeRefName:       DebuggingModes
// 
// TypeRef #5 (01000005)
// -------------------------------------------------------
// Token:             0x01000005
// ResolutionScope:   0x23000001
// TypeRefName:       System.Runtime.Versioning.TargetFrameworkAttribute
// 	MemberRef #1 (0a000004)
// 	-------------------------------------------------------
// 		Member: (0a000004) .ctor: 
// 		CallCnvntn: [DEFAULT]
// 		hasThis 
// 		ReturnType: Void
// 		1 Arguments
// 			Argument #1:  String
// 
// TypeRef #6 (01000006)
// -------------------------------------------------------
// Token:             0x01000006
// ResolutionScope:   0x23000001
// TypeRefName:       System.Reflection.AssemblyCompanyAttribute
// 	MemberRef #1 (0a000005)
// 	-------------------------------------------------------
// 		Member: (0a000005) .ctor: 
// 		CallCnvntn: [DEFAULT]
// 		hasThis 
// 		ReturnType: Void
// 		1 Arguments
// 			Argument #1:  String
// 
// TypeRef #7 (01000007)
// -------------------------------------------------------
// Token:             0x01000007
// ResolutionScope:   0x23000001
// TypeRefName:       System.Reflection.AssemblyConfigurationAttribute
// 	MemberRef #1 (0a000006)
// 	-------------------------------------------------------
// 		Member: (0a000006) .ctor: 
// 		CallCnvntn: [DEFAULT]
// 		hasThis 
// 		ReturnType: Void
// 		1 Arguments
// 			Argument #1:  String
// 
// TypeRef #8 (01000008)
// -------------------------------------------------------
// Token:             0x01000008
// ResolutionScope:   0x23000001
// TypeRefName:       System.Reflection.AssemblyFileVersionAttribute
// 	MemberRef #1 (0a000007)
// 	-------------------------------------------------------
// 		Member: (0a000007) .ctor: 
// 		CallCnvntn: [DEFAULT]
// 		hasThis 
// 		ReturnType: Void
// 		1 Arguments
// 			Argument #1:  String
// 
// TypeRef #9 (01000009)
// -------------------------------------------------------
// Token:             0x01000009
// ResolutionScope:   0x23000001
// TypeRefName:       System.Reflection.AssemblyInformationalVersionAttribute
// 	MemberRef #1 (0a000008)
// 	-------------------------------------------------------
// 		Member: (0a000008) .ctor: 
// 		CallCnvntn: [DEFAULT]
// 		hasThis 
// 		ReturnType: Void
// 		1 Arguments
// 			Argument #1:  String
// 
// TypeRef #10 (0100000a)
// -------------------------------------------------------
// Token:             0x0100000a
// ResolutionScope:   0x23000001
// TypeRefName:       System.Reflection.AssemblyProductAttribute
// 	MemberRef #1 (0a000009)
// 	-------------------------------------------------------
// 		Member: (0a000009) .ctor: 
// 		CallCnvntn: [DEFAULT]
// 		hasThis 
// 		ReturnType: Void
// 		1 Arguments
// 			Argument #1:  String
// 
// TypeRef #11 (0100000b)
// -------------------------------------------------------
// Token:             0x0100000b
// ResolutionScope:   0x23000001
// TypeRefName:       System.Reflection.AssemblyTitleAttribute
// 	MemberRef #1 (0a00000a)
// 	-------------------------------------------------------
// 		Member: (0a00000a) .ctor: 
// 		CallCnvntn: [DEFAULT]
// 		hasThis 
// 		ReturnType: Void
// 		1 Arguments
// 			Argument #1:  String
// 
// TypeRef #12 (0100000c)
// -------------------------------------------------------
// Token:             0x0100000c
// ResolutionScope:   0x23000001
// TypeRefName:       System.Runtime.CompilerServices.RefSafetyRulesAttribute
// 	MemberRef #1 (0a00000b)
// 	-------------------------------------------------------
// 		Member: (0a00000b) .ctor: 
// 		CallCnvntn: [DEFAULT]
// 		hasThis 
// 		ReturnType: Void
// 		1 Arguments
// 			Argument #1:  I4
// 
// TypeRef #13 (0100000d)
// -------------------------------------------------------
// Token:             0x0100000d
// ResolutionScope:   0x23000001
// TypeRefName:       System.Runtime.CompilerServices.CompilerGeneratedAttribute
// 	MemberRef #1 (0a00000c)
// 	-------------------------------------------------------
// 		Member: (0a00000c) .ctor: 
// 		CallCnvntn: [DEFAULT]
// 		hasThis 
// 		ReturnType: Void
// 		No arguments.
// 
// TypeRef #14 (0100000e)
// -------------------------------------------------------
// Token:             0x0100000e
// ResolutionScope:   0x23000001
// TypeRefName:       System.Object
// 	MemberRef #1 (0a000014)
// 	-------------------------------------------------------
// 		Member: (0a000014) .ctor: 
// 		CallCnvntn: [DEFAULT]
// 		hasThis 
// 		ReturnType: Void
// 		No arguments.
// 
// TypeRef #15 (0100000f)
// -------------------------------------------------------
// Token:             0x0100000f
// ResolutionScope:   0x23000001
// TypeRefName:       System.Runtime.CompilerServices.NullableContextAttribute
// 	MemberRef #1 (0a00000d)
// 	-------------------------------------------------------
// 		Member: (0a00000d) .ctor: 
// 		CallCnvntn: [DEFAULT]
// 		hasThis 
// 		ReturnType: Void
// 		1 Arguments
// 			Argument #1:  UI1
// 
// TypeRef #16 (01000010)
// -------------------------------------------------------
// Token:             0x01000010
// ResolutionScope:   0x23000001
// TypeRefName:       System.Runtime.CompilerServices.NullableAttribute
// 	MemberRef #1 (0a00000e)
// 	-------------------------------------------------------
// 		Member: (0a00000e) .ctor: 
// 		CallCnvntn: [DEFAULT]
// 		hasThis 
// 		ReturnType: Void
// 		1 Arguments
// 			Argument #1:  UI1
// 
// TypeRef #17 (01000011)
// -------------------------------------------------------
// Token:             0x01000011
// ResolutionScope:   0x23000001
// TypeRefName:       System.Diagnostics.DebuggerBrowsableState
// 
// TypeRef #18 (01000012)
// -------------------------------------------------------
// Token:             0x01000012
// ResolutionScope:   0x23000001
// TypeRefName:       System.Diagnostics.DebuggerBrowsableAttribute
// 	MemberRef #1 (0a00000f)
// 	-------------------------------------------------------
// 		Member: (0a00000f) .ctor: 
// 		CallCnvntn: [DEFAULT]
// 		hasThis 
// 		ReturnType: Void
// 		1 Arguments
// 			Argument #1:  ValueClass System.Diagnostics.DebuggerBrowsableState
// 
// TypeRef #19 (01000013)
// -------------------------------------------------------
// Token:             0x01000013
// ResolutionScope:   0x23000002
// TypeRefName:       System.Console
// 	MemberRef #1 (0a000010)
// 	-------------------------------------------------------
// 		Member: (0a000010) WriteLine: 
// 		CallCnvntn: [DEFAULT]
// 		ReturnType: Void
// 		1 Arguments
// 			Argument #1:  String
// 	MemberRef #2 (0a000011)
// 	-------------------------------------------------------
// 		Member: (0a000011) ReadLine: 
// 		CallCnvntn: [DEFAULT]
// 		ReturnType: String
// 		No arguments.
// 
// TypeRef #20 (01000014)
// -------------------------------------------------------
// Token:             0x01000014
// ResolutionScope:   0x23000001
// TypeRefName:       System.String
// 	MemberRef #1 (0a000012)
// 	-------------------------------------------------------
// 		Member: (0a000012) ToLower: 
// 		CallCnvntn: [DEFAULT]
// 		hasThis 
// 		ReturnType: String
// 		No arguments.
// 	MemberRef #2 (0a000013)
// 	-------------------------------------------------------
// 		Member: (0a000013) op_Equality: 
// 		CallCnvntn: [DEFAULT]
// 		ReturnType: Boolean
// 		2 Arguments
// 			Argument #1:  String
// 			Argument #2:  String
// 
// Signature #1 (0x11000001)
// -------------------------------------------------------
// 		CallCnvntn: [LOCALSIG]
// 		5 Arguments
// 			Argument #1:  Class CarLibrary.Car
// 			Argument #2:  Boolean
// 			Argument #3:  String
// 			Argument #4:  Boolean
// 			Argument #5:  Boolean
// 
// Assembly
// -------------------------------------------------------
// 	Token: 0x20000001
// 	Name : CarLibrary
// 	Public Key    :
// 	Hash Algorithm : 0x00008004
// 	Version: 1.0.0.0
// 	Major Version: 0x00000001
// 	Minor Version: 0x00000000
// 	Build Number: 0x00000000
// 	Revision Number: 0x00000000
// 	Locale: <null>
// 	Flags : [none] (00000000)
// 	CustomAttribute #1 (0c000004)
// 	-------------------------------------------------------
// 		CustomAttribute Type: 0a000001
// 		CustomAttributeName: System.Runtime.CompilerServices.CompilationRelaxationsAttribute :: instance void .ctor(int32)
// 		Length: 8
// 		Value : 01 00 08 00 00 00 00 00                          >                <
// 		ctor args: (8)
// 
// 	CustomAttribute #2 (0c000005)
// 	-------------------------------------------------------
// 		CustomAttribute Type: 0a000002
// 		CustomAttributeName: System.Runtime.CompilerServices.RuntimeCompatibilityAttribute :: instance void .ctor()
// 		Length: 30
// 		Value : 01 00 01 00 54 02 16 57  72 61 70 4e 6f 6e 45 78 >    T  WrapNonEx<
//                       : 63 65 70 74 69 6f 6e 54  68 72 6f 77 73 01       >ceptionThrows   <
// 		ctor args: ()
// 
// 	CustomAttribute #3 (0c000006)
// 	-------------------------------------------------------
// 		CustomAttribute Type: 0a000003
// 		CustomAttributeName: System.Diagnostics.DebuggableAttribute :: instance void .ctor(value class DebuggingModes)
// 		Length: 8
// 		Value : 01 00 07 01 00 00 00 00                          >                <
// 		ctor args: ( <can not decode> )
// 
// 	CustomAttribute #4 (0c000007)
// 	-------------------------------------------------------
// 		CustomAttribute Type: 0a000004
// 		CustomAttributeName: System.Runtime.Versioning.TargetFrameworkAttribute :: instance void .ctor(class System.String)
// 		Length: 63
// 		Value : 01 00 19 2e 4e 45 54 43  6f 72 65 41 70 70 2c 56 >   .NETCoreApp,V<
//                       : 65 72 73 69 6f 6e 3d 76  31 30 2e 30 01 00 54 0e >ersion=v10.0  T <
//                       : 14 46 72 61 6d 65 77 6f  72 6b 44 69 73 70 6c 61 > FrameworkDispla<
//                       : 79 4e 61 6d 65 09 2e 4e  45 54 20 31 30 2e 30    >yName .NET 10.0 <
// 		ctor args: (".NETCoreApp,Version=v10.0")
// 
// 	CustomAttribute #5 (0c000008)
// 	-------------------------------------------------------
// 		CustomAttribute Type: 0a000005
// 		CustomAttributeName: System.Reflection.AssemblyCompanyAttribute :: instance void .ctor(class System.String)
// 		Length: 15
// 		Value : 01 00 0a 43 61 72 4c 69  62 72 61 72 79 00 00    >   CarLibrary   <
// 		ctor args: ("CarLibrary")
// 
// 	CustomAttribute #6 (0c000009)
// 	-------------------------------------------------------
// 		CustomAttribute Type: 0a000006
// 		CustomAttributeName: System.Reflection.AssemblyConfigurationAttribute :: instance void .ctor(class System.String)
// 		Length: 10
// 		Value : 01 00 05 44 65 62 75 67  00 00                   >   Debug        <
// 		ctor args: ("Debug")
// 
// 	CustomAttribute #7 (0c00000a)
// 	-------------------------------------------------------
// 		CustomAttribute Type: 0a000007
// 		CustomAttributeName: System.Reflection.AssemblyFileVersionAttribute :: instance void .ctor(class System.String)
// 		Length: 12
// 		Value : 01 00 07 31 2e 30 2e 30  2e 30 00 00             >   1.0.0.0      <
// 		ctor args: ("1.0.0.0")
// 
// 	CustomAttribute #8 (0c00000b)
// 	-------------------------------------------------------
// 		CustomAttribute Type: 0a000008
// 		CustomAttributeName: System.Reflection.AssemblyInformationalVersionAttribute :: instance void .ctor(class System.String)
// 		Length: 51
// 		Value : 01 00 2e 31 2e 30 2e 30  2b 34 30 37 63 32 63 66 >  .1.0.0+407c2cf<
//                       : 64 31 62 36 61 66 36 63  64 39 35 35 31 38 34 39 >d1b6af6cd9551849<
//                       : 63 37 65 37 36 33 66 63  62 61 62 62 66 36 62 34 >c7e763fcbabbf6b4<
//                       : 65 00 00                                         >e               <
// 		ctor args: ("1.0.0+407c2cfd1b6af6cd9551849c7e763fcbabbf6b4e")
// 
// 	CustomAttribute #9 (0c00000c)
// 	-------------------------------------------------------
// 		CustomAttribute Type: 0a000009
// 		CustomAttributeName: System.Reflection.AssemblyProductAttribute :: instance void .ctor(class System.String)
// 		Length: 15
// 		Value : 01 00 0a 43 61 72 4c 69  62 72 61 72 79 00 00    >   CarLibrary   <
// 		ctor args: ("CarLibrary")
// 
// 	CustomAttribute #10 (0c00000d)
// 	-------------------------------------------------------
// 		CustomAttribute Type: 0a00000a
// 		CustomAttributeName: System.Reflection.AssemblyTitleAttribute :: instance void .ctor(class System.String)
// 		Length: 15
// 		Value : 01 00 0a 43 61 72 4c 69  62 72 61 72 79 00 00    >   CarLibrary   <
// 		ctor args: ("CarLibrary")
// 
// 
// AssemblyRef #1 (23000001)
// -------------------------------------------------------
// 	Token: 0x23000001
// 	Public Key or Token: b0 3f 5f 7f 11 d5 0a 3a 
// 	Name: System.Runtime
// 	Version: 10.0.0.0
// 	Major Version: 0x0000000a
// 	Minor Version: 0x00000000
// 	Build Number: 0x00000000
// 	Revision Number: 0x00000000
// 	Locale: <null>
// 	HashValue Blob:
// 	Flags: [none] (00000000)
// 
// 
// AssemblyRef #2 (23000002)
// -------------------------------------------------------
// 	Token: 0x23000002
// 	Public Key or Token: b0 3f 5f 7f 11 d5 0a 3a 
// 	Name: System.Console
// 	Version: 10.0.0.0
// 	Major Version: 0x0000000a
// 	Minor Version: 0x00000000
// 	Build Number: 0x00000000
// 	Revision Number: 0x00000000
// 	Locale: <null>
// 	HashValue Blob:
// 	Flags: [none] (00000000)
// 
// 
// User Strings
// -------------------------------------------------------
// 70000001 : (13) L"Hello, World!"
// 7000001d : ( 6) L"Toyota"
// 7000002b : ( 5) L"Camry"
// 70000037 : (45) L"Do you want to activate turbo boost? (yes/no)"
// 70000093 : ( 3) L"yes"
// 7000009b : ( 1) L"y"
// 7000009f : (26) L"Turbo boost not activated."
// 700000d5 : (22) L"Turbo boost activated!"
// 
// 
// Coff symbol name overhead:  0
// ===========================================================
// ===========================================================
// ===========================================================
// ================================= END OF METAINFO ================================================


// Metadata version: v4.0.30319
.assembly extern /*23000001*/ System.Runtime
{
  .publickeytoken = (B0 3F 5F 7F 11 D5 0A 3A )                         // .?_....:
  .ver 10:0:0:0
}
.assembly extern /*23000002*/ System.Console
{
  .publickeytoken = (B0 3F 5F 7F 11 D5 0A 3A )                         // .?_....:
  .ver 10:0:0:0
}
.assembly /*20000001*/ CarLibrary
{
  .custom /*0C000004:0A000001*/ instance void [System.Runtime/*23000001*/]System.Runtime.CompilerServices.CompilationRelaxationsAttribute/*01000001*/::.ctor(int32) /* 0A000001 */ = ( 01 00 08 00 00 00 00 00 ) 
  .custom /*0C000005:0A000002*/ instance void [System.Runtime/*23000001*/]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute/*01000002*/::.ctor() /* 0A000002 */ = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                                                                                                63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- The following custom attribute is added automatically, do not uncomment -------
  //  .custom /*0C000006:0A000003*/ instance void [System.Runtime/*23000001*/]System.Diagnostics.DebuggableAttribute/*01000003*/::.ctor(valuetype [System.Runtime/*23000001*/]System.Diagnostics.DebuggableAttribute/*01000003*//DebuggingModes/*01000004*/) /* 0A000003 */ = ( 01 00 07 01 00 00 00 00 ) 

  .custom /*0C000007:0A000004*/ instance void [System.Runtime/*23000001*/]System.Runtime.Versioning.TargetFrameworkAttribute/*01000005*/::.ctor(string) /* 0A000004 */ = ( 01 00 19 2E 4E 45 54 43 6F 72 65 41 70 70 2C 56   // ....NETCoreApp,V
                                                                                                                                                                           65 72 73 69 6F 6E 3D 76 31 30 2E 30 01 00 54 0E   // ersion=v10.0..T.
                                                                                                                                                                           14 46 72 61 6D 65 77 6F 72 6B 44 69 73 70 6C 61   // .FrameworkDispla
                                                                                                                                                                           79 4E 61 6D 65 09 2E 4E 45 54 20 31 30 2E 30 )    // yName..NET 10.0
  .custom /*0C000008:0A000005*/ instance void [System.Runtime/*23000001*/]System.Reflection.AssemblyCompanyAttribute/*01000006*/::.ctor(string) /* 0A000005 */ = ( 01 00 0A 43 61 72 4C 69 62 72 61 72 79 00 00 )    // ...CarLibrary..
  .custom /*0C000009:0A000006*/ instance void [System.Runtime/*23000001*/]System.Reflection.AssemblyConfigurationAttribute/*01000007*/::.ctor(string) /* 0A000006 */ = ( 01 00 05 44 65 62 75 67 00 00 )                   // ...Debug..
  .custom /*0C00000A:0A000007*/ instance void [System.Runtime/*23000001*/]System.Reflection.AssemblyFileVersionAttribute/*01000008*/::.ctor(string) /* 0A000007 */ = ( 01 00 07 31 2E 30 2E 30 2E 30 00 00 )             // ...1.0.0.0..
  .custom /*0C00000B:0A000008*/ instance void [System.Runtime/*23000001*/]System.Reflection.AssemblyInformationalVersionAttribute/*01000009*/::.ctor(string) /* 0A000008 */ = ( 01 00 2E 31 2E 30 2E 30 2B 34 30 37 63 32 63 66   // ...1.0.0+407c2cf
                                                                                                                                                                                64 31 62 36 61 66 36 63 64 39 35 35 31 38 34 39   // d1b6af6cd9551849
                                                                                                                                                                                63 37 65 37 36 33 66 63 62 61 62 62 66 36 62 34   // c7e763fcbabbf6b4
                                                                                                                                                                                65 00 00 )                                        // e..
  .custom /*0C00000C:0A000009*/ instance void [System.Runtime/*23000001*/]System.Reflection.AssemblyProductAttribute/*0100000A*/::.ctor(string) /* 0A000009 */ = ( 01 00 0A 43 61 72 4C 69 62 72 61 72 79 00 00 )    // ...CarLibrary..
  .custom /*0C00000D:0A00000A*/ instance void [System.Runtime/*23000001*/]System.Reflection.AssemblyTitleAttribute/*0100000B*/::.ctor(string) /* 0A00000A */ = ( 01 00 0A 43 61 72 4C 69 62 72 61 72 79 00 00 )    // ...CarLibrary..
  .hash algorithm 0x00008004
  .ver 1:0:0:0
}
.module CarLibrary.dll
// MVID: {7ADE1A94-BAF6-4314-9836-1DBC7C53D94C}
.custom /*0C000003:0A00000B*/ instance void [System.Runtime/*23000001*/]System.Runtime.CompilerServices.RefSafetyRulesAttribute/*0100000C*/::.ctor(int32) /* 0A00000B */ = ( 01 00 0B 00 00 00 00 00 ) 
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000001    //  ILONLY
// Image base: 0x07530000


// =============== CLASS MEMBERS DECLARATION ===================

.class /*02000002*/ private auto ansi beforefieldinit Program
       extends [System.Runtime/*23000001*/]System.Object/*0100000E*/
{
  .custom /*0C000010:0A00000C*/ instance void [System.Runtime/*23000001*/]System.Runtime.CompilerServices.CompilerGeneratedAttribute/*0100000D*/::.ctor() /* 0A00000C */ = ( 01 00 00 00 ) 
  .method /*06000001*/ private hidebysig static 
          void  '<Main>$'(string[] args) cil managed
  // SIG: 00 01 01 1D 0E
  {
    .entrypoint
    // Method begins at RVA 0x2050
    // Code size       167 (0xa7)
    .maxstack  3
    .locals /*11000001*/ init (class CarLibrary.Car/*02000003*/ V_0,
             bool V_1,
             string V_2,
             bool V_3,
             bool V_4)
    IL_0000:  /* 72   | (70)000001       */ ldstr      "Hello, World! Altered from CIL code!" /* 70000001 */
    IL_0005:  /* 28   | (0A)000010       */ call       void [System.Console/*23000002*/]System.Console/*01000013*/::WriteLine(string) /* 0A000010 */
    IL_000a:  /* 00   |                  */ nop
    IL_000b:  /* 73   | (06)00000A       */ newobj     instance void CarLibrary.Car/*02000003*/::.ctor() /* 0600000A */
    IL_0010:  /* 25   |                  */ dup
    IL_0011:  /* 72   | (70)00001D       */ ldstr      "Toyota" /* 7000001D */
    IL_0016:  /* 6F   | (06)000004       */ callvirt   instance void CarLibrary.Car/*02000003*/::set_Brand(string) /* 06000004 */
    IL_001b:  /* 00   |                  */ nop
    IL_001c:  /* 25   |                  */ dup
    IL_001d:  /* 72   | (70)00002B       */ ldstr      "Camry" /* 7000002B */
    IL_0022:  /* 6F   | (06)000006       */ callvirt   instance void CarLibrary.Car/*02000003*/::set_Model(string) /* 06000006 */
    IL_0027:  /* 00   |                  */ nop
    IL_0028:  /* 25   |                  */ dup
    IL_0029:  /* 20   | E6070000         */ ldc.i4     0x7e6
    IL_002e:  /* 6F   | (06)000008       */ callvirt   instance void CarLibrary.Car/*02000003*/::set_Year(int32) /* 06000008 */
    IL_0033:  /* 00   |                  */ nop
    IL_0034:  /* 0A   |                  */ stloc.0
    IL_0035:  /* 16   |                  */ ldc.i4.0
    IL_0036:  /* 0B   |                  */ stloc.1
    IL_0037:  /* 72   | (70)000037       */ ldstr      "Do you want to activate turbo boost\? (yes/no)" /* 70000037 */
    IL_003c:  /* 28   | (0A)000010       */ call       void [System.Console/*23000002*/]System.Console/*01000013*/::WriteLine(string) /* 0A000010 */
    IL_0041:  /* 00   |                  */ nop
    IL_0042:  /* 28   | (0A)000011       */ call       string [System.Console/*23000002*/]System.Console/*01000013*/::ReadLine() /* 0A000011 */
    IL_0047:  /* 0C   |                  */ stloc.2
    IL_0048:  /* 08   |                  */ ldloc.2
    IL_0049:  /* 2D   | 03               */ brtrue.s   IL_004e

    IL_004b:  /* 14   |                  */ ldnull
    IL_004c:  /* 2B   | 06               */ br.s       IL_0054

    IL_004e:  /* 08   |                  */ ldloc.2
    IL_004f:  /* 28   | (0A)000012       */ call       instance string [System.Runtime/*23000001*/]System.String/*01000014*/::ToLower() /* 0A000012 */
    IL_0054:  /* 72   | (70)000093       */ ldstr      "yes" /* 70000093 */
    IL_0059:  /* 28   | (0A)000013       */ call       bool [System.Runtime/*23000001*/]System.String/*01000014*/::op_Equality(string,
                                                                                                                               string) /* 0A000013 */
    IL_005e:  /* 2D   | 18               */ brtrue.s   IL_0078

    IL_0060:  /* 08   |                  */ ldloc.2
    IL_0061:  /* 2D   | 03               */ brtrue.s   IL_0066

    IL_0063:  /* 14   |                  */ ldnull
    IL_0064:  /* 2B   | 06               */ br.s       IL_006c

    IL_0066:  /* 08   |                  */ ldloc.2
    IL_0067:  /* 28   | (0A)000012       */ call       instance string [System.Runtime/*23000001*/]System.String/*01000014*/::ToLower() /* 0A000012 */
    IL_006c:  /* 72   | (70)00009B       */ ldstr      "y" /* 7000009B */
    IL_0071:  /* 28   | (0A)000013       */ call       bool [System.Runtime/*23000001*/]System.String/*01000014*/::op_Equality(string,
                                                                                                                               string) /* 0A000013 */
    IL_0076:  /* 2B   | 01               */ br.s       IL_0079

    IL_0078:  /* 17   |                  */ ldc.i4.1
    IL_0079:  /* 0D   |                  */ stloc.3
    IL_007a:  /* 09   |                  */ ldloc.3
    IL_007b:  /* 2C   | 04               */ brfalse.s  IL_0081

    IL_007d:  /* 00   |                  */ nop
    IL_007e:  /* 17   |                  */ ldc.i4.1
    IL_007f:  /* 0B   |                  */ stloc.1
    IL_0080:  /* 00   |                  */ nop
    IL_0081:  /* 07   |                  */ ldloc.1
    IL_0082:  /* 13   | 04               */ stloc.s    V_4
    IL_0084:  /* 11   | 04               */ ldloc.s    V_4
    IL_0086:  /* 2C   | 0B               */ brfalse.s  IL_0093

    IL_0088:  /* 00   |                  */ nop
    IL_0089:  /* 06   |                  */ ldloc.0
    IL_008a:  /* 6F   | (06)000009       */ callvirt   instance void CarLibrary.Car/*02000003*/::TurboBoost() /* 06000009 */
    IL_008f:  /* 00   |                  */ nop
    IL_0090:  /* 00   |                  */ nop
    IL_0091:  /* 2B   | 0D               */ br.s       IL_00a0

    IL_0093:  /* 00   |                  */ nop
    IL_0094:  /* 72   | (70)00009F       */ ldstr      "Turbo boost not activated." /* 7000009F */
    IL_0099:  /* 28   | (0A)000010       */ call       void [System.Console/*23000002*/]System.Console/*01000013*/::WriteLine(string) /* 0A000010 */
    IL_009e:  /* 00   |                  */ nop
    IL_009f:  /* 00   |                  */ nop
    IL_00a0:  /* 28   | (0A)000011       */ call       string [System.Console/*23000002*/]System.Console/*01000013*/::ReadLine() /* 0A000011 */
    IL_00a5:  /* 26   |                  */ pop
    IL_00a6:  /* 2A   |                  */ ret
  } // end of method Program::'<Main>$'

  .method /*06000002*/ public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  // SIG: 20 00 01
  {
    // Method begins at RVA 0x2103
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 28   | (0A)000014       */ call       instance void [System.Runtime/*23000001*/]System.Object/*0100000E*/::.ctor() /* 0A000014 */
    IL_0006:  /* 00   |                  */ nop
    IL_0007:  /* 2A   |                  */ ret
  } // end of method Program::.ctor

} // end of class Program

.class /*02000003*/ public auto ansi beforefieldinit CarLibrary.Car
       extends [System.Runtime/*23000001*/]System.Object/*0100000E*/
{
  .custom /*0C000014:0A00000D*/ instance void [System.Runtime/*23000001*/]System.Runtime.CompilerServices.NullableContextAttribute/*0100000F*/::.ctor(uint8) /* 0A00000D */ = ( 01 00 01 00 00 ) 
  .custom /*0C000015:0A00000E*/ instance void [System.Runtime/*23000001*/]System.Runtime.CompilerServices.NullableAttribute/*01000010*/::.ctor(uint8) /* 0A00000E */ = ( 01 00 00 00 00 ) 
  .field /*04000001*/ private string '<Brand>k__BackingField'
  .custom /*0C000001:0A00000C*/ instance void [System.Runtime/*23000001*/]System.Runtime.CompilerServices.CompilerGeneratedAttribute/*0100000D*/::.ctor() /* 0A00000C */ = ( 01 00 00 00 ) 
  .custom /*0C000002:0A00000F*/ instance void [System.Runtime/*23000001*/]System.Diagnostics.DebuggerBrowsableAttribute/*01000012*/::.ctor(valuetype [System.Runtime/*23000001*/]System.Diagnostics.DebuggerBrowsableState/*01000011*/) /* 0A00000F */ = ( 01 00 00 00 00 00 00 00 ) 
  .field /*04000002*/ private string '<Model>k__BackingField'
  .custom /*0C00000E:0A00000C*/ instance void [System.Runtime/*23000001*/]System.Runtime.CompilerServices.CompilerGeneratedAttribute/*0100000D*/::.ctor() /* 0A00000C */ = ( 01 00 00 00 ) 
  .custom /*0C00000F:0A00000F*/ instance void [System.Runtime/*23000001*/]System.Diagnostics.DebuggerBrowsableAttribute/*01000012*/::.ctor(valuetype [System.Runtime/*23000001*/]System.Diagnostics.DebuggerBrowsableState/*01000011*/) /* 0A00000F */ = ( 01 00 00 00 00 00 00 00 ) 
  .field /*04000003*/ private int32 '<Year>k__BackingField'
  .custom /*0C000012:0A00000C*/ instance void [System.Runtime/*23000001*/]System.Runtime.CompilerServices.CompilerGeneratedAttribute/*0100000D*/::.ctor() /* 0A00000C */ = ( 01 00 00 00 ) 
  .custom /*0C000013:0A00000F*/ instance void [System.Runtime/*23000001*/]System.Diagnostics.DebuggerBrowsableAttribute/*01000012*/::.ctor(valuetype [System.Runtime/*23000001*/]System.Diagnostics.DebuggerBrowsableState/*01000011*/) /* 0A00000F */ = ( 01 00 00 00 00 00 00 00 ) 
  .method /*06000003*/ public hidebysig specialname 
          instance string  get_Brand() cil managed
  // SIG: 20 00 0E
  {
    .custom /*0C000011:0A00000C*/ instance void [System.Runtime/*23000001*/]System.Runtime.CompilerServices.CompilerGeneratedAttribute/*0100000D*/::.ctor() /* 0A00000C */ = ( 01 00 00 00 ) 
    // Method begins at RVA 0x210c
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 7B   | (04)000001       */ ldfld      string CarLibrary.Car/*02000003*/::'<Brand>k__BackingField' /* 04000001 */
    IL_0006:  /* 2A   |                  */ ret
  } // end of method Car::get_Brand

  .method /*06000004*/ public hidebysig specialname 
          instance void  set_Brand(string 'value') cil managed
  // SIG: 20 01 01 0E
  {
    .custom /*0C000016:0A00000C*/ instance void [System.Runtime/*23000001*/]System.Runtime.CompilerServices.CompilerGeneratedAttribute/*0100000D*/::.ctor() /* 0A00000C */ = ( 01 00 00 00 ) 
    // Method begins at RVA 0x2114
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 03   |                  */ ldarg.1
    IL_0002:  /* 7D   | (04)000001       */ stfld      string CarLibrary.Car/*02000003*/::'<Brand>k__BackingField' /* 04000001 */
    IL_0007:  /* 2A   |                  */ ret
  } // end of method Car::set_Brand

  .method /*06000005*/ public hidebysig specialname 
          instance string  get_Model() cil managed
  // SIG: 20 00 0E
  {
    .custom /*0C000017:0A00000C*/ instance void [System.Runtime/*23000001*/]System.Runtime.CompilerServices.CompilerGeneratedAttribute/*0100000D*/::.ctor() /* 0A00000C */ = ( 01 00 00 00 ) 
    // Method begins at RVA 0x211d
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 7B   | (04)000002       */ ldfld      string CarLibrary.Car/*02000003*/::'<Model>k__BackingField' /* 04000002 */
    IL_0006:  /* 2A   |                  */ ret
  } // end of method Car::get_Model

  .method /*06000006*/ public hidebysig specialname 
          instance void  set_Model(string 'value') cil managed
  // SIG: 20 01 01 0E
  {
    .custom /*0C000018:0A00000C*/ instance void [System.Runtime/*23000001*/]System.Runtime.CompilerServices.CompilerGeneratedAttribute/*0100000D*/::.ctor() /* 0A00000C */ = ( 01 00 00 00 ) 
    // Method begins at RVA 0x2125
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 03   |                  */ ldarg.1
    IL_0002:  /* 7D   | (04)000002       */ stfld      string CarLibrary.Car/*02000003*/::'<Model>k__BackingField' /* 04000002 */
    IL_0007:  /* 2A   |                  */ ret
  } // end of method Car::set_Model

  .method /*06000007*/ public hidebysig specialname 
          instance int32  get_Year() cil managed
  // SIG: 20 00 08
  {
    .custom /*0C000019:0A00000C*/ instance void [System.Runtime/*23000001*/]System.Runtime.CompilerServices.CompilerGeneratedAttribute/*0100000D*/::.ctor() /* 0A00000C */ = ( 01 00 00 00 ) 
    // Method begins at RVA 0x212e
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 7B   | (04)000003       */ ldfld      int32 CarLibrary.Car/*02000003*/::'<Year>k__BackingField' /* 04000003 */
    IL_0006:  /* 2A   |                  */ ret
  } // end of method Car::get_Year

  .method /*06000008*/ public hidebysig specialname 
          instance void  set_Year(int32 'value') cil managed
  // SIG: 20 01 01 08
  {
    .custom /*0C00001A:0A00000C*/ instance void [System.Runtime/*23000001*/]System.Runtime.CompilerServices.CompilerGeneratedAttribute/*0100000D*/::.ctor() /* 0A00000C */ = ( 01 00 00 00 ) 
    // Method begins at RVA 0x2136
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 03   |                  */ ldarg.1
    IL_0002:  /* 7D   | (04)000003       */ stfld      int32 CarLibrary.Car/*02000003*/::'<Year>k__BackingField' /* 04000003 */
    IL_0007:  /* 2A   |                  */ ret
  } // end of method Car::set_Year

  .method /*06000009*/ public hidebysig instance void 
          TurboBoost() cil managed
  // SIG: 20 00 01
  {
    // Method begins at RVA 0x213f
    // Code size       13 (0xd)
    .maxstack  8
    IL_0000:  /* 00   |                  */ nop
    IL_0001:  /* 72   | (70)0000D5       */ ldstr      "Turbo boost activated!" /* 700000D5 */
    IL_0006:  /* 28   | (0A)000010       */ call       void [System.Console/*23000002*/]System.Console/*01000013*/::WriteLine(string) /* 0A000010 */
    IL_000b:  /* 00   |                  */ nop
    IL_000c:  /* 2A   |                  */ ret
  } // end of method Car::TurboBoost

  .method /*0600000A*/ public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  // SIG: 20 00 01
  {
    // Method begins at RVA 0x214d
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 28   | (0A)000014       */ call       instance void [System.Runtime/*23000001*/]System.Object/*0100000E*/::.ctor() /* 0A000014 */
    IL_0006:  /* 00   |                  */ nop
    IL_0007:  /* 2A   |                  */ ret
  } // end of method Car::.ctor

  .property /*17000001*/ instance string Brand()
  {
    .get instance string CarLibrary.Car/*02000003*/::get_Brand() /* 06000003 */
    .set instance void CarLibrary.Car/*02000003*/::set_Brand(string) /* 06000004 */
  } // end of property Car::Brand
  .property /*17000002*/ instance string Model()
  {
    .get instance string CarLibrary.Car/*02000003*/::get_Model() /* 06000005 */
    .set instance void CarLibrary.Car/*02000003*/::set_Model(string) /* 06000006 */
  } // end of property Car::Model
  .property /*17000003*/ instance int32 Year()
  {
    .get instance int32 CarLibrary.Car/*02000003*/::get_Year() /* 06000007 */
    .set instance void CarLibrary.Car/*02000003*/::set_Year(int32) /* 06000008 */
  } // end of property Car::Year
} // end of class CarLibrary.Car


// =============================================================

// *********** DISASSEMBLY COMPLETE ***********************
// WARNING: Created Win32 resource file .\CarLibrary\CarLibrary.res
