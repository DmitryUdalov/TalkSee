

/* this ALWAYS GENERATED file contains the proxy stub code */


 /* File created by MIDL compiler version 8.00.0595 */
/* at Sat Nov 03 17:09:39 2012
 */
/* Compiler settings for C:\Users\Ashley\AppData\Local\Temp\PhoneVoIPApp.BackEnd.idl-7ddfaca5:
    Oicf, W1, Zp8, env=Win32 (32b run), target_arch=X86 8.00.0595 
    protocol : dce , ms_ext, c_ext, robust
    error checks: allocation ref bounds_check enum stub_data 
    VC __declspec() decoration level: 
         __declspec(uuid()), __declspec(selectany), __declspec(novtable)
         DECLSPEC_UUID(), MIDL_INTERFACE()
*/
/* @@MIDL_FILE_HEADING(  ) */

#if !defined(_M_IA64) && !defined(_M_AMD64) && !defined(_ARM_)


#pragma warning( disable: 4049 )  /* more than 64k source lines */
#if _MSC_VER >= 1200
#pragma warning(push)
#endif

#pragma warning( disable: 4211 )  /* redefine extern to static */
#pragma warning( disable: 4232 )  /* dllimport identity*/
#pragma warning( disable: 4024 )  /* array to pointer mapping*/
#pragma warning( disable: 4152 )  /* function/data pointer conversion in expression */
#pragma warning( disable: 4100 ) /* unreferenced arguments in x86 call */

#pragma optimize("", off ) 

#define USE_STUBLESS_PROXY


/* verify that the <rpcproxy.h> version is high enough to compile this file*/
#ifndef __REDQ_RPCPROXY_H_VERSION__
#define __REQUIRED_RPCPROXY_H_VERSION__ 475
#endif


#include "rpcproxy.h"
#ifndef __RPCPROXY_H_VERSION__
#error this stub requires an updated version of <rpcproxy.h>
#endif /* __RPCPROXY_H_VERSION__ */


#include "PhoneVoIPApp.BackEnd.h"

#define TYPE_FORMAT_STRING_SIZE   331                               
#define PROC_FORMAT_STRING_SIZE   1873                              
#define EXPR_FORMAT_STRING_SIZE   1                                 
#define TRANSMIT_AS_TABLE_SIZE    0            
#define WIRE_MARSHAL_TABLE_SIZE   1            

typedef struct _PhoneVoIPApp2EBackEnd_MIDL_TYPE_FORMAT_STRING
    {
    short          Pad;
    unsigned char  Format[ TYPE_FORMAT_STRING_SIZE ];
    } PhoneVoIPApp2EBackEnd_MIDL_TYPE_FORMAT_STRING;

typedef struct _PhoneVoIPApp2EBackEnd_MIDL_PROC_FORMAT_STRING
    {
    short          Pad;
    unsigned char  Format[ PROC_FORMAT_STRING_SIZE ];
    } PhoneVoIPApp2EBackEnd_MIDL_PROC_FORMAT_STRING;

typedef struct _PhoneVoIPApp2EBackEnd_MIDL_EXPR_FORMAT_STRING
    {
    long          Pad;
    unsigned char  Format[ EXPR_FORMAT_STRING_SIZE ];
    } PhoneVoIPApp2EBackEnd_MIDL_EXPR_FORMAT_STRING;


static const RPC_SYNTAX_IDENTIFIER  _RpcTransferSyntax = 
{{0x8A885D04,0x1CEB,0x11C9,{0x9F,0xE8,0x08,0x00,0x2B,0x10,0x48,0x60}},{2,0}};


extern const PhoneVoIPApp2EBackEnd_MIDL_TYPE_FORMAT_STRING PhoneVoIPApp2EBackEnd__MIDL_TypeFormatString;
extern const PhoneVoIPApp2EBackEnd_MIDL_PROC_FORMAT_STRING PhoneVoIPApp2EBackEnd__MIDL_ProcFormatString;
extern const PhoneVoIPApp2EBackEnd_MIDL_EXPR_FORMAT_STRING PhoneVoIPApp2EBackEnd__MIDL_ExprFormatString;


extern const MIDL_STUB_DESC Object_StubDesc;


extern const MIDL_SERVER_INFO __x_ABI_CPhoneVoIPApp_CBackEnd_CIMessageReceivedEventHandler_ServerInfo;
extern const MIDL_STUBLESS_PROXY_INFO __x_ABI_CPhoneVoIPApp_CBackEnd_CIMessageReceivedEventHandler_ProxyInfo;


extern const MIDL_STUB_DESC Object_StubDesc;


extern const MIDL_SERVER_INFO __x_ABI_CPhoneVoIPApp_CBackEnd_CICameraLocationChangedEventHandler_ServerInfo;
extern const MIDL_STUBLESS_PROXY_INFO __x_ABI_CPhoneVoIPApp_CBackEnd_CICameraLocationChangedEventHandler_ProxyInfo;


extern const MIDL_STUB_DESC Object_StubDesc;


extern const MIDL_SERVER_INFO __x_ABI_CPhoneVoIPApp_CBackEnd_CIIncomingCallDialogDismissedCallback_ServerInfo;
extern const MIDL_STUBLESS_PROXY_INFO __x_ABI_CPhoneVoIPApp_CBackEnd_CIIncomingCallDialogDismissedCallback_ProxyInfo;


extern const MIDL_STUB_DESC Object_StubDesc;


extern const MIDL_SERVER_INFO __x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndTransportPublicNonVirtuals_ServerInfo;
extern const MIDL_STUBLESS_PROXY_INFO __x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndTransportPublicNonVirtuals_ProxyInfo;


extern const MIDL_STUB_DESC Object_StubDesc;


extern const MIDL_SERVER_INFO __x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndTransportProtectedNonVirtuals_ServerInfo;
extern const MIDL_STUBLESS_PROXY_INFO __x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndTransportProtectedNonVirtuals_ProxyInfo;


extern const MIDL_STUB_DESC Object_StubDesc;


extern const MIDL_SERVER_INFO __x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndAudioPublicNonVirtuals_ServerInfo;
extern const MIDL_STUBLESS_PROXY_INFO __x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndAudioPublicNonVirtuals_ProxyInfo;


extern const MIDL_STUB_DESC Object_StubDesc;


extern const MIDL_SERVER_INFO __x_ABI_CPhoneVoIPApp_CBackEnd_CICallControllerStatusListener_ServerInfo;
extern const MIDL_STUBLESS_PROXY_INFO __x_ABI_CPhoneVoIPApp_CBackEnd_CICallControllerStatusListener_ProxyInfo;


extern const MIDL_STUB_DESC Object_StubDesc;


extern const MIDL_SERVER_INFO __x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndCapturePublicNonVirtuals_ServerInfo;
extern const MIDL_STUBLESS_PROXY_INFO __x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndCapturePublicNonVirtuals_ProxyInfo;


extern const MIDL_STUB_DESC Object_StubDesc;


extern const MIDL_SERVER_INFO __x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndCaptureProtectedNonVirtuals_ServerInfo;
extern const MIDL_STUBLESS_PROXY_INFO __x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndCaptureProtectedNonVirtuals_ProxyInfo;


extern const MIDL_STUB_DESC Object_StubDesc;


extern const MIDL_SERVER_INFO __x_ABI_CPhoneVoIPApp_CBackEnd_C____ICallControllerPublicNonVirtuals_ServerInfo;
extern const MIDL_STUBLESS_PROXY_INFO __x_ABI_CPhoneVoIPApp_CBackEnd_C____ICallControllerPublicNonVirtuals_ProxyInfo;


extern const MIDL_STUB_DESC Object_StubDesc;


extern const MIDL_SERVER_INFO __x_ABI_CPhoneVoIPApp_CBackEnd_CIVideoRenderer_ServerInfo;
extern const MIDL_STUBLESS_PROXY_INFO __x_ABI_CPhoneVoIPApp_CBackEnd_CIVideoRenderer_ProxyInfo;


extern const MIDL_STUB_DESC Object_StubDesc;


extern const MIDL_SERVER_INFO __x_ABI_CPhoneVoIPApp_CBackEnd_C____IGlobalsPublicNonVirtuals_ServerInfo;
extern const MIDL_STUBLESS_PROXY_INFO __x_ABI_CPhoneVoIPApp_CBackEnd_C____IGlobalsPublicNonVirtuals_ProxyInfo;


extern const MIDL_STUB_DESC Object_StubDesc;


extern const MIDL_SERVER_INFO __x_ABI_CPhoneVoIPApp_CBackEnd_C____IGlobalsStatics_ServerInfo;
extern const MIDL_STUBLESS_PROXY_INFO __x_ABI_CPhoneVoIPApp_CBackEnd_C____IGlobalsStatics_ProxyInfo;


extern const USER_MARSHAL_ROUTINE_QUADRUPLE UserMarshalRoutines[ WIRE_MARSHAL_TABLE_SIZE ];

#if !defined(__RPC_WIN32__)
#error  Invalid build platform for this stub.
#endif

#if !(TARGET_IS_NT50_OR_LATER)
#error You need Windows 2000 or later to run this stub because it uses these features:
#error   /robust command line switch.
#error However, your C/C++ compilation flags indicate you intend to run this app on earlier systems.
#error This app will fail with the RPC_X_WRONG_STUB_VERSION error.
#endif


static const PhoneVoIPApp2EBackEnd_MIDL_PROC_FORMAT_STRING PhoneVoIPApp2EBackEnd__MIDL_ProcFormatString =
    {
        0,
        {

	/* Procedure Invoke */

			0x33,		/* FC_AUTO_HANDLE */
			0x6c,		/* Old Flags:  object, Oi2 */
/*  2 */	NdrFcLong( 0x0 ),	/* 0 */
/*  6 */	NdrFcShort( 0x3 ),	/* 3 */
/*  8 */	NdrFcShort( 0x1c ),	/* x86 Stack size/offset = 28 */
/* 10 */	NdrFcShort( 0x20 ),	/* 32 */
/* 12 */	NdrFcShort( 0x8 ),	/* 8 */
/* 14 */	0x46,		/* Oi2 Flags:  clt must size, has return, has ext, */
			0x4,		/* 4 */
/* 16 */	0x8,		/* 8 */
			0x1,		/* Ext Flags:  new corr desc, */
/* 18 */	NdrFcShort( 0x0 ),	/* 0 */
/* 20 */	NdrFcShort( 0x0 ),	/* 0 */
/* 22 */	NdrFcShort( 0x0 ),	/* 0 */

	/* Parameter __param0 */

/* 24 */	NdrFcShort( 0xb ),	/* Flags:  must size, must free, in, */
/* 26 */	NdrFcShort( 0x4 ),	/* x86 Stack size/offset = 4 */
/* 28 */	NdrFcShort( 0x2 ),	/* Type Offset=2 */

	/* Parameter __param1 */

/* 30 */	NdrFcShort( 0x48 ),	/* Flags:  in, base type, */
/* 32 */	NdrFcShort( 0x8 ),	/* x86 Stack size/offset = 8 */
/* 34 */	0xb,		/* FC_HYPER */
			0x0,		/* 0 */

	/* Parameter __param2 */

/* 36 */	NdrFcShort( 0x48 ),	/* Flags:  in, base type, */
/* 38 */	NdrFcShort( 0x10 ),	/* x86 Stack size/offset = 16 */
/* 40 */	0xb,		/* FC_HYPER */
			0x0,		/* 0 */

	/* Return value */

/* 42 */	NdrFcShort( 0x70 ),	/* Flags:  out, return, base type, */
/* 44 */	NdrFcShort( 0x18 ),	/* x86 Stack size/offset = 24 */
/* 46 */	0x8,		/* FC_LONG */
			0x0,		/* 0 */

	/* Procedure Invoke */

/* 48 */	0x33,		/* FC_AUTO_HANDLE */
			0x6c,		/* Old Flags:  object, Oi2 */
/* 50 */	NdrFcLong( 0x0 ),	/* 0 */
/* 54 */	NdrFcShort( 0x3 ),	/* 3 */
/* 56 */	NdrFcShort( 0xc ),	/* x86 Stack size/offset = 12 */
/* 58 */	NdrFcShort( 0x8 ),	/* 8 */
/* 60 */	NdrFcShort( 0x8 ),	/* 8 */
/* 62 */	0x44,		/* Oi2 Flags:  has return, has ext, */
			0x2,		/* 2 */
/* 64 */	0x8,		/* 8 */
			0x1,		/* Ext Flags:  new corr desc, */
/* 66 */	NdrFcShort( 0x0 ),	/* 0 */
/* 68 */	NdrFcShort( 0x0 ),	/* 0 */
/* 70 */	NdrFcShort( 0x0 ),	/* 0 */

	/* Parameter __param0 */

/* 72 */	NdrFcShort( 0x48 ),	/* Flags:  in, base type, */
/* 74 */	NdrFcShort( 0x4 ),	/* x86 Stack size/offset = 4 */
/* 76 */	0xe,		/* FC_ENUM32 */
			0x0,		/* 0 */

	/* Return value */

/* 78 */	NdrFcShort( 0x70 ),	/* Flags:  out, return, base type, */
/* 80 */	NdrFcShort( 0x8 ),	/* x86 Stack size/offset = 8 */
/* 82 */	0x8,		/* FC_LONG */
			0x0,		/* 0 */

	/* Procedure Invoke */

/* 84 */	0x33,		/* FC_AUTO_HANDLE */
			0x6c,		/* Old Flags:  object, Oi2 */
/* 86 */	NdrFcLong( 0x0 ),	/* 0 */
/* 90 */	NdrFcShort( 0x3 ),	/* 3 */
/* 92 */	NdrFcShort( 0x8 ),	/* x86 Stack size/offset = 8 */
/* 94 */	NdrFcShort( 0x0 ),	/* 0 */
/* 96 */	NdrFcShort( 0x8 ),	/* 8 */
/* 98 */	0x44,		/* Oi2 Flags:  has return, has ext, */
			0x1,		/* 1 */
/* 100 */	0x8,		/* 8 */
			0x1,		/* Ext Flags:  new corr desc, */
/* 102 */	NdrFcShort( 0x0 ),	/* 0 */
/* 104 */	NdrFcShort( 0x0 ),	/* 0 */
/* 106 */	NdrFcShort( 0x0 ),	/* 0 */

	/* Return value */

/* 108 */	NdrFcShort( 0x70 ),	/* Flags:  out, return, base type, */
/* 110 */	NdrFcShort( 0x4 ),	/* x86 Stack size/offset = 4 */
/* 112 */	0x8,		/* FC_LONG */
			0x0,		/* 0 */

	/* Procedure WriteAudio */

/* 114 */	0x33,		/* FC_AUTO_HANDLE */
			0x6c,		/* Old Flags:  object, Oi2 */
/* 116 */	NdrFcLong( 0x0 ),	/* 0 */
/* 120 */	NdrFcShort( 0x6 ),	/* 6 */
/* 122 */	NdrFcShort( 0x10 ),	/* x86 Stack size/offset = 16 */
/* 124 */	NdrFcShort( 0x8 ),	/* 8 */
/* 126 */	NdrFcShort( 0x21 ),	/* 33 */
/* 128 */	0x44,		/* Oi2 Flags:  has return, has ext, */
			0x3,		/* 3 */
/* 130 */	0x8,		/* 8 */
			0x1,		/* Ext Flags:  new corr desc, */
/* 132 */	NdrFcShort( 0x0 ),	/* 0 */
/* 134 */	NdrFcShort( 0x0 ),	/* 0 */
/* 136 */	NdrFcShort( 0x0 ),	/* 0 */

	/* Parameter bytes */

/* 138 */	NdrFcShort( 0x2150 ),	/* Flags:  out, base type, simple ref, srv alloc size=8 */
/* 140 */	NdrFcShort( 0x4 ),	/* x86 Stack size/offset = 4 */
/* 142 */	0x1,		/* FC_BYTE */
			0x0,		/* 0 */

	/* Parameter byteCount */

/* 144 */	NdrFcShort( 0x48 ),	/* Flags:  in, base type, */
/* 146 */	NdrFcShort( 0x8 ),	/* x86 Stack size/offset = 8 */
/* 148 */	0x8,		/* FC_LONG */
			0x0,		/* 0 */

	/* Return value */

/* 150 */	NdrFcShort( 0x70 ),	/* Flags:  out, return, base type, */
/* 152 */	NdrFcShort( 0xc ),	/* x86 Stack size/offset = 12 */
/* 154 */	0x8,		/* FC_LONG */
			0x0,		/* 0 */

	/* Procedure WriteVideo */

/* 156 */	0x33,		/* FC_AUTO_HANDLE */
			0x6c,		/* Old Flags:  object, Oi2 */
/* 158 */	NdrFcLong( 0x0 ),	/* 0 */
/* 162 */	NdrFcShort( 0x7 ),	/* 7 */
/* 164 */	NdrFcShort( 0x20 ),	/* x86 Stack size/offset = 32 */
/* 166 */	NdrFcShort( 0x28 ),	/* 40 */
/* 168 */	NdrFcShort( 0x21 ),	/* 33 */
/* 170 */	0x44,		/* Oi2 Flags:  has return, has ext, */
			0x5,		/* 5 */
/* 172 */	0x8,		/* 8 */
			0x1,		/* Ext Flags:  new corr desc, */
/* 174 */	NdrFcShort( 0x0 ),	/* 0 */
/* 176 */	NdrFcShort( 0x0 ),	/* 0 */
/* 178 */	NdrFcShort( 0x0 ),	/* 0 */

	/* Parameter bytes */

/* 180 */	NdrFcShort( 0x2150 ),	/* Flags:  out, base type, simple ref, srv alloc size=8 */
/* 182 */	NdrFcShort( 0x4 ),	/* x86 Stack size/offset = 4 */
/* 184 */	0x1,		/* FC_BYTE */
			0x0,		/* 0 */

	/* Parameter byteCount */

/* 186 */	NdrFcShort( 0x48 ),	/* Flags:  in, base type, */
/* 188 */	NdrFcShort( 0x8 ),	/* x86 Stack size/offset = 8 */
/* 190 */	0x8,		/* FC_LONG */
			0x0,		/* 0 */

	/* Parameter hnsPresentationTime */

/* 192 */	NdrFcShort( 0x48 ),	/* Flags:  in, base type, */
/* 194 */	NdrFcShort( 0xc ),	/* x86 Stack size/offset = 12 */
/* 196 */	0xb,		/* FC_HYPER */
			0x0,		/* 0 */

	/* Parameter hnsSampleDuration */

/* 198 */	NdrFcShort( 0x48 ),	/* Flags:  in, base type, */
/* 200 */	NdrFcShort( 0x14 ),	/* x86 Stack size/offset = 20 */
/* 202 */	0xb,		/* FC_HYPER */
			0x0,		/* 0 */

	/* Return value */

/* 204 */	NdrFcShort( 0x70 ),	/* Flags:  out, return, base type, */
/* 206 */	NdrFcShort( 0x1c ),	/* x86 Stack size/offset = 28 */
/* 208 */	0x8,		/* FC_LONG */
			0x0,		/* 0 */

	/* Procedure add_AudioMessageReceived */

/* 210 */	0x33,		/* FC_AUTO_HANDLE */
			0x6c,		/* Old Flags:  object, Oi2 */
/* 212 */	NdrFcLong( 0x0 ),	/* 0 */
/* 216 */	NdrFcShort( 0x8 ),	/* 8 */
/* 218 */	NdrFcShort( 0x10 ),	/* x86 Stack size/offset = 16 */
/* 220 */	NdrFcShort( 0x0 ),	/* 0 */
/* 222 */	NdrFcShort( 0x34 ),	/* 52 */
/* 224 */	0x46,		/* Oi2 Flags:  clt must size, has return, has ext, */
			0x3,		/* 3 */
/* 226 */	0x8,		/* 8 */
			0x1,		/* Ext Flags:  new corr desc, */
/* 228 */	NdrFcShort( 0x0 ),	/* 0 */
/* 230 */	NdrFcShort( 0x0 ),	/* 0 */
/* 232 */	NdrFcShort( 0x0 ),	/* 0 */

	/* Parameter __param0 */

/* 234 */	NdrFcShort( 0xb ),	/* Flags:  must size, must free, in, */
/* 236 */	NdrFcShort( 0x4 ),	/* x86 Stack size/offset = 4 */
/* 238 */	NdrFcShort( 0x18 ),	/* Type Offset=24 */

	/* Parameter __returnValue */

/* 240 */	NdrFcShort( 0x2112 ),	/* Flags:  must free, out, simple ref, srv alloc size=8 */
/* 242 */	NdrFcShort( 0x8 ),	/* x86 Stack size/offset = 8 */
/* 244 */	NdrFcShort( 0x2e ),	/* Type Offset=46 */

	/* Return value */

/* 246 */	NdrFcShort( 0x70 ),	/* Flags:  out, return, base type, */
/* 248 */	NdrFcShort( 0xc ),	/* x86 Stack size/offset = 12 */
/* 250 */	0x8,		/* FC_LONG */
			0x0,		/* 0 */

	/* Procedure remove_AudioMessageReceived */

/* 252 */	0x33,		/* FC_AUTO_HANDLE */
			0x6c,		/* Old Flags:  object, Oi2 */
/* 254 */	NdrFcLong( 0x0 ),	/* 0 */
/* 258 */	NdrFcShort( 0x9 ),	/* 9 */
/* 260 */	NdrFcShort( 0x10 ),	/* x86 Stack size/offset = 16 */
/* 262 */	NdrFcShort( 0x18 ),	/* 24 */
/* 264 */	NdrFcShort( 0x8 ),	/* 8 */
/* 266 */	0x44,		/* Oi2 Flags:  has return, has ext, */
			0x2,		/* 2 */
/* 268 */	0x8,		/* 8 */
			0x1,		/* Ext Flags:  new corr desc, */
/* 270 */	NdrFcShort( 0x0 ),	/* 0 */
/* 272 */	NdrFcShort( 0x0 ),	/* 0 */
/* 274 */	NdrFcShort( 0x0 ),	/* 0 */

	/* Parameter __param0 */

/* 276 */	NdrFcShort( 0x8a ),	/* Flags:  must free, in, by val, */
/* 278 */	NdrFcShort( 0x4 ),	/* x86 Stack size/offset = 4 */
/* 280 */	NdrFcShort( 0x2e ),	/* Type Offset=46 */

	/* Return value */

/* 282 */	NdrFcShort( 0x70 ),	/* Flags:  out, return, base type, */
/* 284 */	NdrFcShort( 0xc ),	/* x86 Stack size/offset = 12 */
/* 286 */	0x8,		/* FC_LONG */
			0x0,		/* 0 */

	/* Procedure add_VideoMessageReceived */

/* 288 */	0x33,		/* FC_AUTO_HANDLE */
			0x6c,		/* Old Flags:  object, Oi2 */
/* 290 */	NdrFcLong( 0x0 ),	/* 0 */
/* 294 */	NdrFcShort( 0xa ),	/* 10 */
/* 296 */	NdrFcShort( 0x10 ),	/* x86 Stack size/offset = 16 */
/* 298 */	NdrFcShort( 0x0 ),	/* 0 */
/* 300 */	NdrFcShort( 0x34 ),	/* 52 */
/* 302 */	0x46,		/* Oi2 Flags:  clt must size, has return, has ext, */
			0x3,		/* 3 */
/* 304 */	0x8,		/* 8 */
			0x1,		/* Ext Flags:  new corr desc, */
/* 306 */	NdrFcShort( 0x0 ),	/* 0 */
/* 308 */	NdrFcShort( 0x0 ),	/* 0 */
/* 310 */	NdrFcShort( 0x0 ),	/* 0 */

	/* Parameter __param0 */

/* 312 */	NdrFcShort( 0xb ),	/* Flags:  must size, must free, in, */
/* 314 */	NdrFcShort( 0x4 ),	/* x86 Stack size/offset = 4 */
/* 316 */	NdrFcShort( 0x18 ),	/* Type Offset=24 */

	/* Parameter __returnValue */

/* 318 */	NdrFcShort( 0x2112 ),	/* Flags:  must free, out, simple ref, srv alloc size=8 */
/* 320 */	NdrFcShort( 0x8 ),	/* x86 Stack size/offset = 8 */
/* 322 */	NdrFcShort( 0x2e ),	/* Type Offset=46 */

	/* Return value */

/* 324 */	NdrFcShort( 0x70 ),	/* Flags:  out, return, base type, */
/* 326 */	NdrFcShort( 0xc ),	/* x86 Stack size/offset = 12 */
/* 328 */	0x8,		/* FC_LONG */
			0x0,		/* 0 */

	/* Procedure remove_CameraLocationChanged */


	/* Procedure remove_VideoMessageReceived */

/* 330 */	0x33,		/* FC_AUTO_HANDLE */
			0x6c,		/* Old Flags:  object, Oi2 */
/* 332 */	NdrFcLong( 0x0 ),	/* 0 */
/* 336 */	NdrFcShort( 0xb ),	/* 11 */
/* 338 */	NdrFcShort( 0x10 ),	/* x86 Stack size/offset = 16 */
/* 340 */	NdrFcShort( 0x18 ),	/* 24 */
/* 342 */	NdrFcShort( 0x8 ),	/* 8 */
/* 344 */	0x44,		/* Oi2 Flags:  has return, has ext, */
			0x2,		/* 2 */
/* 346 */	0x8,		/* 8 */
			0x1,		/* Ext Flags:  new corr desc, */
/* 348 */	NdrFcShort( 0x0 ),	/* 0 */
/* 350 */	NdrFcShort( 0x0 ),	/* 0 */
/* 352 */	NdrFcShort( 0x0 ),	/* 0 */

	/* Parameter __param0 */


	/* Parameter __param0 */

/* 354 */	NdrFcShort( 0x8a ),	/* Flags:  must free, in, by val, */
/* 356 */	NdrFcShort( 0x4 ),	/* x86 Stack size/offset = 4 */
/* 358 */	NdrFcShort( 0x2e ),	/* Type Offset=46 */

	/* Return value */


	/* Return value */

/* 360 */	NdrFcShort( 0x70 ),	/* Flags:  out, return, base type, */
/* 362 */	NdrFcShort( 0xc ),	/* x86 Stack size/offset = 12 */
/* 364 */	0x8,		/* FC_LONG */
			0x0,		/* 0 */

	/* Procedure SetTransport */


	/* Procedure SetTransport */

/* 366 */	0x33,		/* FC_AUTO_HANDLE */
			0x6c,		/* Old Flags:  object, Oi2 */
/* 368 */	NdrFcLong( 0x0 ),	/* 0 */
/* 372 */	NdrFcShort( 0x6 ),	/* 6 */
/* 374 */	NdrFcShort( 0xc ),	/* x86 Stack size/offset = 12 */
/* 376 */	NdrFcShort( 0x0 ),	/* 0 */
/* 378 */	NdrFcShort( 0x8 ),	/* 8 */
/* 380 */	0x46,		/* Oi2 Flags:  clt must size, has return, has ext, */
			0x2,		/* 2 */
/* 382 */	0x8,		/* 8 */
			0x1,		/* Ext Flags:  new corr desc, */
/* 384 */	NdrFcShort( 0x0 ),	/* 0 */
/* 386 */	NdrFcShort( 0x0 ),	/* 0 */
/* 388 */	NdrFcShort( 0x0 ),	/* 0 */

	/* Parameter transport */


	/* Parameter transport */

/* 390 */	NdrFcShort( 0xb ),	/* Flags:  must size, must free, in, */
/* 392 */	NdrFcShort( 0x4 ),	/* x86 Stack size/offset = 4 */
/* 394 */	NdrFcShort( 0x34 ),	/* Type Offset=52 */

	/* Return value */


	/* Return value */

/* 396 */	NdrFcShort( 0x70 ),	/* Flags:  out, return, base type, */
/* 398 */	NdrFcShort( 0x8 ),	/* x86 Stack size/offset = 8 */
/* 400 */	0x8,		/* FC_LONG */
			0x0,		/* 0 */

	/* Procedure DoPeriodicKeepAlive */


	/* Procedure Stop */


	/* Procedure Start */

/* 402 */	0x33,		/* FC_AUTO_HANDLE */
			0x6c,		/* Old Flags:  object, Oi2 */
/* 404 */	NdrFcLong( 0x0 ),	/* 0 */
/* 408 */	NdrFcShort( 0x7 ),	/* 7 */
/* 410 */	NdrFcShort( 0x8 ),	/* x86 Stack size/offset = 8 */
/* 412 */	NdrFcShort( 0x0 ),	/* 0 */
/* 414 */	NdrFcShort( 0x8 ),	/* 8 */
/* 416 */	0x44,		/* Oi2 Flags:  has return, has ext, */
			0x1,		/* 1 */
/* 418 */	0x8,		/* 8 */
			0x1,		/* Ext Flags:  new corr desc, */
/* 420 */	NdrFcShort( 0x0 ),	/* 0 */
/* 422 */	NdrFcShort( 0x0 ),	/* 0 */
/* 424 */	NdrFcShort( 0x0 ),	/* 0 */

	/* Return value */


	/* Return value */


	/* Return value */

/* 426 */	NdrFcShort( 0x70 ),	/* Flags:  out, return, base type, */
/* 428 */	NdrFcShort( 0x4 ),	/* x86 Stack size/offset = 4 */
/* 430 */	0x8,		/* FC_LONG */
			0x0,		/* 0 */

	/* Procedure Stop */


	/* Procedure Stop */

/* 432 */	0x33,		/* FC_AUTO_HANDLE */
			0x6c,		/* Old Flags:  object, Oi2 */
/* 434 */	NdrFcLong( 0x0 ),	/* 0 */
/* 438 */	NdrFcShort( 0x8 ),	/* 8 */
/* 440 */	NdrFcShort( 0x8 ),	/* x86 Stack size/offset = 8 */
/* 442 */	NdrFcShort( 0x0 ),	/* 0 */
/* 444 */	NdrFcShort( 0x8 ),	/* 8 */
/* 446 */	0x44,		/* Oi2 Flags:  has return, has ext, */
			0x1,		/* 1 */
/* 448 */	0x8,		/* 8 */
			0x1,		/* Ext Flags:  new corr desc, */
/* 450 */	NdrFcShort( 0x0 ),	/* 0 */
/* 452 */	NdrFcShort( 0x0 ),	/* 0 */
/* 454 */	NdrFcShort( 0x0 ),	/* 0 */

	/* Return value */


	/* Return value */

/* 456 */	NdrFcShort( 0x70 ),	/* Flags:  out, return, base type, */
/* 458 */	NdrFcShort( 0x4 ),	/* x86 Stack size/offset = 4 */
/* 460 */	0x8,		/* FC_LONG */
			0x0,		/* 0 */

	/* Procedure OnCallStatusChanged */

/* 462 */	0x33,		/* FC_AUTO_HANDLE */
			0x6c,		/* Old Flags:  object, Oi2 */
/* 464 */	NdrFcLong( 0x0 ),	/* 0 */
/* 468 */	NdrFcShort( 0x6 ),	/* 6 */
/* 470 */	NdrFcShort( 0xc ),	/* x86 Stack size/offset = 12 */
/* 472 */	NdrFcShort( 0x8 ),	/* 8 */
/* 474 */	NdrFcShort( 0x8 ),	/* 8 */
/* 476 */	0x44,		/* Oi2 Flags:  has return, has ext, */
			0x2,		/* 2 */
/* 478 */	0x8,		/* 8 */
			0x1,		/* Ext Flags:  new corr desc, */
/* 480 */	NdrFcShort( 0x0 ),	/* 0 */
/* 482 */	NdrFcShort( 0x0 ),	/* 0 */
/* 484 */	NdrFcShort( 0x0 ),	/* 0 */

	/* Parameter newStatus */

/* 486 */	NdrFcShort( 0x48 ),	/* Flags:  in, base type, */
/* 488 */	NdrFcShort( 0x4 ),	/* x86 Stack size/offset = 4 */
/* 490 */	0xe,		/* FC_ENUM32 */
			0x0,		/* 0 */

	/* Return value */

/* 492 */	NdrFcShort( 0x70 ),	/* Flags:  out, return, base type, */
/* 494 */	NdrFcShort( 0x8 ),	/* x86 Stack size/offset = 8 */
/* 496 */	0x8,		/* FC_LONG */
			0x0,		/* 0 */

	/* Procedure Start */


	/* Procedure OnCallAudioRouteChanged */

/* 498 */	0x33,		/* FC_AUTO_HANDLE */
			0x6c,		/* Old Flags:  object, Oi2 */
/* 500 */	NdrFcLong( 0x0 ),	/* 0 */
/* 504 */	NdrFcShort( 0x7 ),	/* 7 */
/* 506 */	NdrFcShort( 0xc ),	/* x86 Stack size/offset = 12 */
/* 508 */	NdrFcShort( 0x8 ),	/* 8 */
/* 510 */	NdrFcShort( 0x8 ),	/* 8 */
/* 512 */	0x44,		/* Oi2 Flags:  has return, has ext, */
			0x2,		/* 2 */
/* 514 */	0x8,		/* 8 */
			0x1,		/* Ext Flags:  new corr desc, */
/* 516 */	NdrFcShort( 0x0 ),	/* 0 */
/* 518 */	NdrFcShort( 0x0 ),	/* 0 */
/* 520 */	NdrFcShort( 0x0 ),	/* 0 */

	/* Parameter cameraLocation */


	/* Parameter newRoute */

/* 522 */	NdrFcShort( 0x48 ),	/* Flags:  in, base type, */
/* 524 */	NdrFcShort( 0x4 ),	/* x86 Stack size/offset = 4 */
/* 526 */	0xe,		/* FC_ENUM32 */
			0x0,		/* 0 */

	/* Return value */


	/* Return value */

/* 528 */	NdrFcShort( 0x70 ),	/* Flags:  out, return, base type, */
/* 530 */	NdrFcShort( 0x8 ),	/* x86 Stack size/offset = 8 */
/* 532 */	0x8,		/* FC_LONG */
			0x0,		/* 0 */

	/* Procedure OnMediaOperationsChanged */

/* 534 */	0x33,		/* FC_AUTO_HANDLE */
			0x6c,		/* Old Flags:  object, Oi2 */
/* 536 */	NdrFcLong( 0x0 ),	/* 0 */
/* 540 */	NdrFcShort( 0x8 ),	/* 8 */
/* 542 */	NdrFcShort( 0xc ),	/* x86 Stack size/offset = 12 */
/* 544 */	NdrFcShort( 0x8 ),	/* 8 */
/* 546 */	NdrFcShort( 0x8 ),	/* 8 */
/* 548 */	0x44,		/* Oi2 Flags:  has return, has ext, */
			0x2,		/* 2 */
/* 550 */	0x8,		/* 8 */
			0x1,		/* Ext Flags:  new corr desc, */
/* 552 */	NdrFcShort( 0x0 ),	/* 0 */
/* 554 */	NdrFcShort( 0x0 ),	/* 0 */
/* 556 */	NdrFcShort( 0x0 ),	/* 0 */

	/* Parameter newOperations */

/* 558 */	NdrFcShort( 0x48 ),	/* Flags:  in, base type, */
/* 560 */	NdrFcShort( 0x4 ),	/* x86 Stack size/offset = 4 */
/* 562 */	0xe,		/* FC_ENUM32 */
			0x0,		/* 0 */

	/* Return value */

/* 564 */	NdrFcShort( 0x70 ),	/* Flags:  out, return, base type, */
/* 566 */	NdrFcShort( 0x8 ),	/* x86 Stack size/offset = 8 */
/* 568 */	0x8,		/* FC_LONG */
			0x0,		/* 0 */

	/* Procedure OnCameraLocationChanged */

/* 570 */	0x33,		/* FC_AUTO_HANDLE */
			0x6c,		/* Old Flags:  object, Oi2 */
/* 572 */	NdrFcLong( 0x0 ),	/* 0 */
/* 576 */	NdrFcShort( 0x9 ),	/* 9 */
/* 578 */	NdrFcShort( 0xc ),	/* x86 Stack size/offset = 12 */
/* 580 */	NdrFcShort( 0x8 ),	/* 8 */
/* 582 */	NdrFcShort( 0x8 ),	/* 8 */
/* 584 */	0x44,		/* Oi2 Flags:  has return, has ext, */
			0x2,		/* 2 */
/* 586 */	0x8,		/* 8 */
			0x1,		/* Ext Flags:  new corr desc, */
/* 588 */	NdrFcShort( 0x0 ),	/* 0 */
/* 590 */	NdrFcShort( 0x0 ),	/* 0 */
/* 592 */	NdrFcShort( 0x0 ),	/* 0 */

	/* Parameter newCameraLocation */

/* 594 */	NdrFcShort( 0x48 ),	/* Flags:  in, base type, */
/* 596 */	NdrFcShort( 0x4 ),	/* x86 Stack size/offset = 4 */
/* 598 */	0xe,		/* FC_ENUM32 */
			0x0,		/* 0 */

	/* Return value */

/* 600 */	NdrFcShort( 0x70 ),	/* Flags:  out, return, base type, */
/* 602 */	NdrFcShort( 0x8 ),	/* x86 Stack size/offset = 8 */
/* 604 */	0x8,		/* FC_LONG */
			0x0,		/* 0 */

	/* Procedure ToggleCamera */

/* 606 */	0x33,		/* FC_AUTO_HANDLE */
			0x6c,		/* Old Flags:  object, Oi2 */
/* 608 */	NdrFcLong( 0x0 ),	/* 0 */
/* 612 */	NdrFcShort( 0x9 ),	/* 9 */
/* 614 */	NdrFcShort( 0x8 ),	/* x86 Stack size/offset = 8 */
/* 616 */	NdrFcShort( 0x0 ),	/* 0 */
/* 618 */	NdrFcShort( 0x8 ),	/* 8 */
/* 620 */	0x44,		/* Oi2 Flags:  has return, has ext, */
			0x1,		/* 1 */
/* 622 */	0x8,		/* 8 */
			0x1,		/* Ext Flags:  new corr desc, */
/* 624 */	NdrFcShort( 0x0 ),	/* 0 */
/* 626 */	NdrFcShort( 0x0 ),	/* 0 */
/* 628 */	NdrFcShort( 0x0 ),	/* 0 */

	/* Return value */

/* 630 */	NdrFcShort( 0x70 ),	/* Flags:  out, return, base type, */
/* 632 */	NdrFcShort( 0x4 ),	/* x86 Stack size/offset = 4 */
/* 634 */	0x8,		/* FC_LONG */
			0x0,		/* 0 */

	/* Procedure add_CameraLocationChanged */

/* 636 */	0x33,		/* FC_AUTO_HANDLE */
			0x6c,		/* Old Flags:  object, Oi2 */
/* 638 */	NdrFcLong( 0x0 ),	/* 0 */
/* 642 */	NdrFcShort( 0xa ),	/* 10 */
/* 644 */	NdrFcShort( 0x10 ),	/* x86 Stack size/offset = 16 */
/* 646 */	NdrFcShort( 0x0 ),	/* 0 */
/* 648 */	NdrFcShort( 0x34 ),	/* 52 */
/* 650 */	0x46,		/* Oi2 Flags:  clt must size, has return, has ext, */
			0x3,		/* 3 */
/* 652 */	0x8,		/* 8 */
			0x1,		/* Ext Flags:  new corr desc, */
/* 654 */	NdrFcShort( 0x0 ),	/* 0 */
/* 656 */	NdrFcShort( 0x0 ),	/* 0 */
/* 658 */	NdrFcShort( 0x0 ),	/* 0 */

	/* Parameter __param0 */

/* 660 */	NdrFcShort( 0xb ),	/* Flags:  must size, must free, in, */
/* 662 */	NdrFcShort( 0x4 ),	/* x86 Stack size/offset = 4 */
/* 664 */	NdrFcShort( 0x46 ),	/* Type Offset=70 */

	/* Parameter __returnValue */

/* 666 */	NdrFcShort( 0x2112 ),	/* Flags:  must free, out, simple ref, srv alloc size=8 */
/* 668 */	NdrFcShort( 0x8 ),	/* x86 Stack size/offset = 8 */
/* 670 */	NdrFcShort( 0x2e ),	/* Type Offset=46 */

	/* Return value */

/* 672 */	NdrFcShort( 0x70 ),	/* Flags:  out, return, base type, */
/* 674 */	NdrFcShort( 0xc ),	/* x86 Stack size/offset = 12 */
/* 676 */	0x8,		/* FC_LONG */
			0x0,		/* 0 */

	/* Procedure SetStatusCallback */

/* 678 */	0x33,		/* FC_AUTO_HANDLE */
			0x6c,		/* Old Flags:  object, Oi2 */
/* 680 */	NdrFcLong( 0x0 ),	/* 0 */
/* 684 */	NdrFcShort( 0x6 ),	/* 6 */
/* 686 */	NdrFcShort( 0xc ),	/* x86 Stack size/offset = 12 */
/* 688 */	NdrFcShort( 0x0 ),	/* 0 */
/* 690 */	NdrFcShort( 0x8 ),	/* 8 */
/* 692 */	0x46,		/* Oi2 Flags:  clt must size, has return, has ext, */
			0x2,		/* 2 */
/* 694 */	0x8,		/* 8 */
			0x1,		/* Ext Flags:  new corr desc, */
/* 696 */	NdrFcShort( 0x0 ),	/* 0 */
/* 698 */	NdrFcShort( 0x0 ),	/* 0 */
/* 700 */	NdrFcShort( 0x0 ),	/* 0 */

	/* Parameter statusListener */

/* 702 */	NdrFcShort( 0xb ),	/* Flags:  must size, must free, in, */
/* 704 */	NdrFcShort( 0x4 ),	/* x86 Stack size/offset = 4 */
/* 706 */	NdrFcShort( 0x58 ),	/* Type Offset=88 */

	/* Return value */

/* 708 */	NdrFcShort( 0x70 ),	/* Flags:  out, return, base type, */
/* 710 */	NdrFcShort( 0x8 ),	/* x86 Stack size/offset = 8 */
/* 712 */	0x8,		/* FC_LONG */
			0x0,		/* 0 */

	/* Procedure InitiateOutgoingCall */

/* 714 */	0x33,		/* FC_AUTO_HANDLE */
			0x6c,		/* Old Flags:  object, Oi2 */
/* 716 */	NdrFcLong( 0x0 ),	/* 0 */
/* 720 */	NdrFcShort( 0x7 ),	/* 7 */
/* 722 */	NdrFcShort( 0x14 ),	/* x86 Stack size/offset = 20 */
/* 724 */	NdrFcShort( 0x0 ),	/* 0 */
/* 726 */	NdrFcShort( 0x21 ),	/* 33 */
/* 728 */	0x46,		/* Oi2 Flags:  clt must size, has return, has ext, */
			0x4,		/* 4 */
/* 730 */	0x8,		/* 8 */
			0x5,		/* Ext Flags:  new corr desc, srv corr check, */
/* 732 */	NdrFcShort( 0x0 ),	/* 0 */
/* 734 */	NdrFcShort( 0x1 ),	/* 1 */
/* 736 */	NdrFcShort( 0x0 ),	/* 0 */

	/* Parameter recepientName */

/* 738 */	NdrFcShort( 0x8b ),	/* Flags:  must size, must free, in, by val, */
/* 740 */	NdrFcShort( 0x4 ),	/* x86 Stack size/offset = 4 */
/* 742 */	NdrFcShort( 0x84 ),	/* Type Offset=132 */

	/* Parameter recepientNumber */

/* 744 */	NdrFcShort( 0x8b ),	/* Flags:  must size, must free, in, by val, */
/* 746 */	NdrFcShort( 0x8 ),	/* x86 Stack size/offset = 8 */
/* 748 */	NdrFcShort( 0x84 ),	/* Type Offset=132 */

	/* Parameter __returnValue */

/* 750 */	NdrFcShort( 0x2150 ),	/* Flags:  out, base type, simple ref, srv alloc size=8 */
/* 752 */	NdrFcShort( 0xc ),	/* x86 Stack size/offset = 12 */
/* 754 */	0x3,		/* FC_SMALL */
			0x0,		/* 0 */

	/* Return value */

/* 756 */	NdrFcShort( 0x70 ),	/* Flags:  out, return, base type, */
/* 758 */	NdrFcShort( 0x10 ),	/* x86 Stack size/offset = 16 */
/* 760 */	0x8,		/* FC_LONG */
			0x0,		/* 0 */

	/* Procedure OnIncomingCallReceived */

/* 762 */	0x33,		/* FC_AUTO_HANDLE */
			0x6c,		/* Old Flags:  object, Oi2 */
/* 764 */	NdrFcLong( 0x0 ),	/* 0 */
/* 768 */	NdrFcShort( 0x8 ),	/* 8 */
/* 770 */	NdrFcShort( 0x18 ),	/* x86 Stack size/offset = 24 */
/* 772 */	NdrFcShort( 0x0 ),	/* 0 */
/* 774 */	NdrFcShort( 0x21 ),	/* 33 */
/* 776 */	0x46,		/* Oi2 Flags:  clt must size, has return, has ext, */
			0x5,		/* 5 */
/* 778 */	0x8,		/* 8 */
			0x5,		/* Ext Flags:  new corr desc, srv corr check, */
/* 780 */	NdrFcShort( 0x0 ),	/* 0 */
/* 782 */	NdrFcShort( 0x1 ),	/* 1 */
/* 784 */	NdrFcShort( 0x0 ),	/* 0 */

	/* Parameter contactName */

/* 786 */	NdrFcShort( 0x8b ),	/* Flags:  must size, must free, in, by val, */
/* 788 */	NdrFcShort( 0x4 ),	/* x86 Stack size/offset = 4 */
/* 790 */	NdrFcShort( 0x84 ),	/* Type Offset=132 */

	/* Parameter contactNumber */

/* 792 */	NdrFcShort( 0x8b ),	/* Flags:  must size, must free, in, by val, */
/* 794 */	NdrFcShort( 0x8 ),	/* x86 Stack size/offset = 8 */
/* 796 */	NdrFcShort( 0x84 ),	/* Type Offset=132 */

	/* Parameter incomingCallDialogDismissedCallback */

/* 798 */	NdrFcShort( 0xb ),	/* Flags:  must size, must free, in, */
/* 800 */	NdrFcShort( 0xc ),	/* x86 Stack size/offset = 12 */
/* 802 */	NdrFcShort( 0x92 ),	/* Type Offset=146 */

	/* Parameter __returnValue */

/* 804 */	NdrFcShort( 0x2150 ),	/* Flags:  out, base type, simple ref, srv alloc size=8 */
/* 806 */	NdrFcShort( 0x10 ),	/* x86 Stack size/offset = 16 */
/* 808 */	0x3,		/* FC_SMALL */
			0x0,		/* 0 */

	/* Return value */

/* 810 */	NdrFcShort( 0x70 ),	/* Flags:  out, return, base type, */
/* 812 */	NdrFcShort( 0x14 ),	/* x86 Stack size/offset = 20 */
/* 814 */	0x8,		/* FC_LONG */
			0x0,		/* 0 */

	/* Procedure HoldCall */

/* 816 */	0x33,		/* FC_AUTO_HANDLE */
			0x6c,		/* Old Flags:  object, Oi2 */
/* 818 */	NdrFcLong( 0x0 ),	/* 0 */
/* 822 */	NdrFcShort( 0x9 ),	/* 9 */
/* 824 */	NdrFcShort( 0xc ),	/* x86 Stack size/offset = 12 */
/* 826 */	NdrFcShort( 0x0 ),	/* 0 */
/* 828 */	NdrFcShort( 0x21 ),	/* 33 */
/* 830 */	0x44,		/* Oi2 Flags:  has return, has ext, */
			0x2,		/* 2 */
/* 832 */	0x8,		/* 8 */
			0x1,		/* Ext Flags:  new corr desc, */
/* 834 */	NdrFcShort( 0x0 ),	/* 0 */
/* 836 */	NdrFcShort( 0x0 ),	/* 0 */
/* 838 */	NdrFcShort( 0x0 ),	/* 0 */

	/* Parameter __returnValue */

/* 840 */	NdrFcShort( 0x2150 ),	/* Flags:  out, base type, simple ref, srv alloc size=8 */
/* 842 */	NdrFcShort( 0x4 ),	/* x86 Stack size/offset = 4 */
/* 844 */	0x3,		/* FC_SMALL */
			0x0,		/* 0 */

	/* Return value */

/* 846 */	NdrFcShort( 0x70 ),	/* Flags:  out, return, base type, */
/* 848 */	NdrFcShort( 0x8 ),	/* x86 Stack size/offset = 8 */
/* 850 */	0x8,		/* FC_LONG */
			0x0,		/* 0 */

	/* Procedure ResumeCall */

/* 852 */	0x33,		/* FC_AUTO_HANDLE */
			0x6c,		/* Old Flags:  object, Oi2 */
/* 854 */	NdrFcLong( 0x0 ),	/* 0 */
/* 858 */	NdrFcShort( 0xa ),	/* 10 */
/* 860 */	NdrFcShort( 0xc ),	/* x86 Stack size/offset = 12 */
/* 862 */	NdrFcShort( 0x0 ),	/* 0 */
/* 864 */	NdrFcShort( 0x21 ),	/* 33 */
/* 866 */	0x44,		/* Oi2 Flags:  has return, has ext, */
			0x2,		/* 2 */
/* 868 */	0x8,		/* 8 */
			0x1,		/* Ext Flags:  new corr desc, */
/* 870 */	NdrFcShort( 0x0 ),	/* 0 */
/* 872 */	NdrFcShort( 0x0 ),	/* 0 */
/* 874 */	NdrFcShort( 0x0 ),	/* 0 */

	/* Parameter __returnValue */

/* 876 */	NdrFcShort( 0x2150 ),	/* Flags:  out, base type, simple ref, srv alloc size=8 */
/* 878 */	NdrFcShort( 0x4 ),	/* x86 Stack size/offset = 4 */
/* 880 */	0x3,		/* FC_SMALL */
			0x0,		/* 0 */

	/* Return value */

/* 882 */	NdrFcShort( 0x70 ),	/* Flags:  out, return, base type, */
/* 884 */	NdrFcShort( 0x8 ),	/* x86 Stack size/offset = 8 */
/* 886 */	0x8,		/* FC_LONG */
			0x0,		/* 0 */

	/* Procedure EndCall */

/* 888 */	0x33,		/* FC_AUTO_HANDLE */
			0x6c,		/* Old Flags:  object, Oi2 */
/* 890 */	NdrFcLong( 0x0 ),	/* 0 */
/* 894 */	NdrFcShort( 0xb ),	/* 11 */
/* 896 */	NdrFcShort( 0xc ),	/* x86 Stack size/offset = 12 */
/* 898 */	NdrFcShort( 0x0 ),	/* 0 */
/* 900 */	NdrFcShort( 0x21 ),	/* 33 */
/* 902 */	0x44,		/* Oi2 Flags:  has return, has ext, */
			0x2,		/* 2 */
/* 904 */	0x8,		/* 8 */
			0x1,		/* Ext Flags:  new corr desc, */
/* 906 */	NdrFcShort( 0x0 ),	/* 0 */
/* 908 */	NdrFcShort( 0x0 ),	/* 0 */
/* 910 */	NdrFcShort( 0x0 ),	/* 0 */

	/* Parameter __returnValue */

/* 912 */	NdrFcShort( 0x2150 ),	/* Flags:  out, base type, simple ref, srv alloc size=8 */
/* 914 */	NdrFcShort( 0x4 ),	/* x86 Stack size/offset = 4 */
/* 916 */	0x3,		/* FC_SMALL */
			0x0,		/* 0 */

	/* Return value */

/* 918 */	NdrFcShort( 0x70 ),	/* Flags:  out, return, base type, */
/* 920 */	NdrFcShort( 0x8 ),	/* x86 Stack size/offset = 8 */
/* 922 */	0x8,		/* FC_LONG */
			0x0,		/* 0 */

	/* Procedure ToggleCamera */

/* 924 */	0x33,		/* FC_AUTO_HANDLE */
			0x6c,		/* Old Flags:  object, Oi2 */
/* 926 */	NdrFcLong( 0x0 ),	/* 0 */
/* 930 */	NdrFcShort( 0xc ),	/* 12 */
/* 932 */	NdrFcShort( 0xc ),	/* x86 Stack size/offset = 12 */
/* 934 */	NdrFcShort( 0x0 ),	/* 0 */
/* 936 */	NdrFcShort( 0x21 ),	/* 33 */
/* 938 */	0x44,		/* Oi2 Flags:  has return, has ext, */
			0x2,		/* 2 */
/* 940 */	0x8,		/* 8 */
			0x1,		/* Ext Flags:  new corr desc, */
/* 942 */	NdrFcShort( 0x0 ),	/* 0 */
/* 944 */	NdrFcShort( 0x0 ),	/* 0 */
/* 946 */	NdrFcShort( 0x0 ),	/* 0 */

	/* Parameter __returnValue */

/* 948 */	NdrFcShort( 0x2150 ),	/* Flags:  out, base type, simple ref, srv alloc size=8 */
/* 950 */	NdrFcShort( 0x4 ),	/* x86 Stack size/offset = 4 */
/* 952 */	0x3,		/* FC_SMALL */
			0x0,		/* 0 */

	/* Return value */

/* 954 */	NdrFcShort( 0x70 ),	/* Flags:  out, return, base type, */
/* 956 */	NdrFcShort( 0x8 ),	/* x86 Stack size/offset = 8 */
/* 958 */	0x8,		/* FC_LONG */
			0x0,		/* 0 */

	/* Procedure get_CallStatus */

/* 960 */	0x33,		/* FC_AUTO_HANDLE */
			0x6c,		/* Old Flags:  object, Oi2 */
/* 962 */	NdrFcLong( 0x0 ),	/* 0 */
/* 966 */	NdrFcShort( 0xd ),	/* 13 */
/* 968 */	NdrFcShort( 0xc ),	/* x86 Stack size/offset = 12 */
/* 970 */	NdrFcShort( 0x0 ),	/* 0 */
/* 972 */	NdrFcShort( 0x24 ),	/* 36 */
/* 974 */	0x44,		/* Oi2 Flags:  has return, has ext, */
			0x2,		/* 2 */
/* 976 */	0x8,		/* 8 */
			0x1,		/* Ext Flags:  new corr desc, */
/* 978 */	NdrFcShort( 0x0 ),	/* 0 */
/* 980 */	NdrFcShort( 0x0 ),	/* 0 */
/* 982 */	NdrFcShort( 0x0 ),	/* 0 */

	/* Parameter __returnValue */

/* 984 */	NdrFcShort( 0x2150 ),	/* Flags:  out, base type, simple ref, srv alloc size=8 */
/* 986 */	NdrFcShort( 0x4 ),	/* x86 Stack size/offset = 4 */
/* 988 */	0xe,		/* FC_ENUM32 */
			0x0,		/* 0 */

	/* Return value */

/* 990 */	NdrFcShort( 0x70 ),	/* Flags:  out, return, base type, */
/* 992 */	NdrFcShort( 0x8 ),	/* x86 Stack size/offset = 8 */
/* 994 */	0x8,		/* FC_LONG */
			0x0,		/* 0 */

	/* Procedure get_MediaOperations */

/* 996 */	0x33,		/* FC_AUTO_HANDLE */
			0x6c,		/* Old Flags:  object, Oi2 */
/* 998 */	NdrFcLong( 0x0 ),	/* 0 */
/* 1002 */	NdrFcShort( 0xe ),	/* 14 */
/* 1004 */	NdrFcShort( 0xc ),	/* x86 Stack size/offset = 12 */
/* 1006 */	NdrFcShort( 0x0 ),	/* 0 */
/* 1008 */	NdrFcShort( 0x24 ),	/* 36 */
/* 1010 */	0x44,		/* Oi2 Flags:  has return, has ext, */
			0x2,		/* 2 */
/* 1012 */	0x8,		/* 8 */
			0x1,		/* Ext Flags:  new corr desc, */
/* 1014 */	NdrFcShort( 0x0 ),	/* 0 */
/* 1016 */	NdrFcShort( 0x0 ),	/* 0 */
/* 1018 */	NdrFcShort( 0x0 ),	/* 0 */

	/* Parameter __returnValue */

/* 1020 */	NdrFcShort( 0x2150 ),	/* Flags:  out, base type, simple ref, srv alloc size=8 */
/* 1022 */	NdrFcShort( 0x4 ),	/* x86 Stack size/offset = 4 */
/* 1024 */	0xe,		/* FC_ENUM32 */
			0x0,		/* 0 */

	/* Return value */

/* 1026 */	NdrFcShort( 0x70 ),	/* Flags:  out, return, base type, */
/* 1028 */	NdrFcShort( 0x8 ),	/* x86 Stack size/offset = 8 */
/* 1030 */	0x8,		/* FC_LONG */
			0x0,		/* 0 */

	/* Procedure get_IsShowingVideo */

/* 1032 */	0x33,		/* FC_AUTO_HANDLE */
			0x6c,		/* Old Flags:  object, Oi2 */
/* 1034 */	NdrFcLong( 0x0 ),	/* 0 */
/* 1038 */	NdrFcShort( 0xf ),	/* 15 */
/* 1040 */	NdrFcShort( 0xc ),	/* x86 Stack size/offset = 12 */
/* 1042 */	NdrFcShort( 0x0 ),	/* 0 */
/* 1044 */	NdrFcShort( 0x21 ),	/* 33 */
/* 1046 */	0x44,		/* Oi2 Flags:  has return, has ext, */
			0x2,		/* 2 */
/* 1048 */	0x8,		/* 8 */
			0x1,		/* Ext Flags:  new corr desc, */
/* 1050 */	NdrFcShort( 0x0 ),	/* 0 */
/* 1052 */	NdrFcShort( 0x0 ),	/* 0 */
/* 1054 */	NdrFcShort( 0x0 ),	/* 0 */

	/* Parameter __returnValue */

/* 1056 */	NdrFcShort( 0x2150 ),	/* Flags:  out, base type, simple ref, srv alloc size=8 */
/* 1058 */	NdrFcShort( 0x4 ),	/* x86 Stack size/offset = 4 */
/* 1060 */	0x3,		/* FC_SMALL */
			0x0,		/* 0 */

	/* Return value */

/* 1062 */	NdrFcShort( 0x70 ),	/* Flags:  out, return, base type, */
/* 1064 */	NdrFcShort( 0x8 ),	/* x86 Stack size/offset = 8 */
/* 1066 */	0x8,		/* FC_LONG */
			0x0,		/* 0 */

	/* Procedure put_IsShowingVideo */

/* 1068 */	0x33,		/* FC_AUTO_HANDLE */
			0x6c,		/* Old Flags:  object, Oi2 */
/* 1070 */	NdrFcLong( 0x0 ),	/* 0 */
/* 1074 */	NdrFcShort( 0x10 ),	/* 16 */
/* 1076 */	NdrFcShort( 0xc ),	/* x86 Stack size/offset = 12 */
/* 1078 */	NdrFcShort( 0x5 ),	/* 5 */
/* 1080 */	NdrFcShort( 0x8 ),	/* 8 */
/* 1082 */	0x44,		/* Oi2 Flags:  has return, has ext, */
			0x2,		/* 2 */
/* 1084 */	0x8,		/* 8 */
			0x1,		/* Ext Flags:  new corr desc, */
/* 1086 */	NdrFcShort( 0x0 ),	/* 0 */
/* 1088 */	NdrFcShort( 0x0 ),	/* 0 */
/* 1090 */	NdrFcShort( 0x0 ),	/* 0 */

	/* Parameter value */

/* 1092 */	NdrFcShort( 0x48 ),	/* Flags:  in, base type, */
/* 1094 */	NdrFcShort( 0x4 ),	/* x86 Stack size/offset = 4 */
/* 1096 */	0x3,		/* FC_SMALL */
			0x0,		/* 0 */

	/* Return value */

/* 1098 */	NdrFcShort( 0x70 ),	/* Flags:  out, return, base type, */
/* 1100 */	NdrFcShort( 0x8 ),	/* x86 Stack size/offset = 8 */
/* 1102 */	0x8,		/* FC_LONG */
			0x0,		/* 0 */

	/* Procedure get_IsRenderingVideo */

/* 1104 */	0x33,		/* FC_AUTO_HANDLE */
			0x6c,		/* Old Flags:  object, Oi2 */
/* 1106 */	NdrFcLong( 0x0 ),	/* 0 */
/* 1110 */	NdrFcShort( 0x11 ),	/* 17 */
/* 1112 */	NdrFcShort( 0xc ),	/* x86 Stack size/offset = 12 */
/* 1114 */	NdrFcShort( 0x0 ),	/* 0 */
/* 1116 */	NdrFcShort( 0x21 ),	/* 33 */
/* 1118 */	0x44,		/* Oi2 Flags:  has return, has ext, */
			0x2,		/* 2 */
/* 1120 */	0x8,		/* 8 */
			0x1,		/* Ext Flags:  new corr desc, */
/* 1122 */	NdrFcShort( 0x0 ),	/* 0 */
/* 1124 */	NdrFcShort( 0x0 ),	/* 0 */
/* 1126 */	NdrFcShort( 0x0 ),	/* 0 */

	/* Parameter __returnValue */

/* 1128 */	NdrFcShort( 0x2150 ),	/* Flags:  out, base type, simple ref, srv alloc size=8 */
/* 1130 */	NdrFcShort( 0x4 ),	/* x86 Stack size/offset = 4 */
/* 1132 */	0x3,		/* FC_SMALL */
			0x0,		/* 0 */

	/* Return value */

/* 1134 */	NdrFcShort( 0x70 ),	/* Flags:  out, return, base type, */
/* 1136 */	NdrFcShort( 0x8 ),	/* x86 Stack size/offset = 8 */
/* 1138 */	0x8,		/* FC_LONG */
			0x0,		/* 0 */

	/* Procedure put_IsRenderingVideo */

/* 1140 */	0x33,		/* FC_AUTO_HANDLE */
			0x6c,		/* Old Flags:  object, Oi2 */
/* 1142 */	NdrFcLong( 0x0 ),	/* 0 */
/* 1146 */	NdrFcShort( 0x12 ),	/* 18 */
/* 1148 */	NdrFcShort( 0xc ),	/* x86 Stack size/offset = 12 */
/* 1150 */	NdrFcShort( 0x5 ),	/* 5 */
/* 1152 */	NdrFcShort( 0x8 ),	/* 8 */
/* 1154 */	0x44,		/* Oi2 Flags:  has return, has ext, */
			0x2,		/* 2 */
/* 1156 */	0x8,		/* 8 */
			0x1,		/* Ext Flags:  new corr desc, */
/* 1158 */	NdrFcShort( 0x0 ),	/* 0 */
/* 1160 */	NdrFcShort( 0x0 ),	/* 0 */
/* 1162 */	NdrFcShort( 0x0 ),	/* 0 */

	/* Parameter value */

/* 1164 */	NdrFcShort( 0x48 ),	/* Flags:  in, base type, */
/* 1166 */	NdrFcShort( 0x4 ),	/* x86 Stack size/offset = 4 */
/* 1168 */	0x3,		/* FC_SMALL */
			0x0,		/* 0 */

	/* Return value */

/* 1170 */	NdrFcShort( 0x70 ),	/* Flags:  out, return, base type, */
/* 1172 */	NdrFcShort( 0x8 ),	/* x86 Stack size/offset = 8 */
/* 1174 */	0x8,		/* FC_LONG */
			0x0,		/* 0 */

	/* Procedure get_CameraLocation */

/* 1176 */	0x33,		/* FC_AUTO_HANDLE */
			0x6c,		/* Old Flags:  object, Oi2 */
/* 1178 */	NdrFcLong( 0x0 ),	/* 0 */
/* 1182 */	NdrFcShort( 0x13 ),	/* 19 */
/* 1184 */	NdrFcShort( 0xc ),	/* x86 Stack size/offset = 12 */
/* 1186 */	NdrFcShort( 0x0 ),	/* 0 */
/* 1188 */	NdrFcShort( 0x24 ),	/* 36 */
/* 1190 */	0x44,		/* Oi2 Flags:  has return, has ext, */
			0x2,		/* 2 */
/* 1192 */	0x8,		/* 8 */
			0x1,		/* Ext Flags:  new corr desc, */
/* 1194 */	NdrFcShort( 0x0 ),	/* 0 */
/* 1196 */	NdrFcShort( 0x0 ),	/* 0 */
/* 1198 */	NdrFcShort( 0x0 ),	/* 0 */

	/* Parameter __returnValue */

/* 1200 */	NdrFcShort( 0x2150 ),	/* Flags:  out, base type, simple ref, srv alloc size=8 */
/* 1202 */	NdrFcShort( 0x4 ),	/* x86 Stack size/offset = 4 */
/* 1204 */	0xe,		/* FC_ENUM32 */
			0x0,		/* 0 */

	/* Return value */

/* 1206 */	NdrFcShort( 0x70 ),	/* Flags:  out, return, base type, */
/* 1208 */	NdrFcShort( 0x8 ),	/* x86 Stack size/offset = 8 */
/* 1210 */	0x8,		/* FC_LONG */
			0x0,		/* 0 */

	/* Procedure get_AvailableAudioRoutes */

/* 1212 */	0x33,		/* FC_AUTO_HANDLE */
			0x6c,		/* Old Flags:  object, Oi2 */
/* 1214 */	NdrFcLong( 0x0 ),	/* 0 */
/* 1218 */	NdrFcShort( 0x14 ),	/* 20 */
/* 1220 */	NdrFcShort( 0xc ),	/* x86 Stack size/offset = 12 */
/* 1222 */	NdrFcShort( 0x0 ),	/* 0 */
/* 1224 */	NdrFcShort( 0x24 ),	/* 36 */
/* 1226 */	0x44,		/* Oi2 Flags:  has return, has ext, */
			0x2,		/* 2 */
/* 1228 */	0x8,		/* 8 */
			0x1,		/* Ext Flags:  new corr desc, */
/* 1230 */	NdrFcShort( 0x0 ),	/* 0 */
/* 1232 */	NdrFcShort( 0x0 ),	/* 0 */
/* 1234 */	NdrFcShort( 0x0 ),	/* 0 */

	/* Parameter __returnValue */

/* 1236 */	NdrFcShort( 0x2150 ),	/* Flags:  out, base type, simple ref, srv alloc size=8 */
/* 1238 */	NdrFcShort( 0x4 ),	/* x86 Stack size/offset = 4 */
/* 1240 */	0xe,		/* FC_ENUM32 */
			0x0,		/* 0 */

	/* Return value */

/* 1242 */	NdrFcShort( 0x70 ),	/* Flags:  out, return, base type, */
/* 1244 */	NdrFcShort( 0x8 ),	/* x86 Stack size/offset = 8 */
/* 1246 */	0x8,		/* FC_LONG */
			0x0,		/* 0 */

	/* Procedure get_AudioRoute */

/* 1248 */	0x33,		/* FC_AUTO_HANDLE */
			0x6c,		/* Old Flags:  object, Oi2 */
/* 1250 */	NdrFcLong( 0x0 ),	/* 0 */
/* 1254 */	NdrFcShort( 0x15 ),	/* 21 */
/* 1256 */	NdrFcShort( 0xc ),	/* x86 Stack size/offset = 12 */
/* 1258 */	NdrFcShort( 0x0 ),	/* 0 */
/* 1260 */	NdrFcShort( 0x24 ),	/* 36 */
/* 1262 */	0x44,		/* Oi2 Flags:  has return, has ext, */
			0x2,		/* 2 */
/* 1264 */	0x8,		/* 8 */
			0x1,		/* Ext Flags:  new corr desc, */
/* 1266 */	NdrFcShort( 0x0 ),	/* 0 */
/* 1268 */	NdrFcShort( 0x0 ),	/* 0 */
/* 1270 */	NdrFcShort( 0x0 ),	/* 0 */

	/* Parameter __returnValue */

/* 1272 */	NdrFcShort( 0x2150 ),	/* Flags:  out, base type, simple ref, srv alloc size=8 */
/* 1274 */	NdrFcShort( 0x4 ),	/* x86 Stack size/offset = 4 */
/* 1276 */	0xe,		/* FC_ENUM32 */
			0x0,		/* 0 */

	/* Return value */

/* 1278 */	NdrFcShort( 0x70 ),	/* Flags:  out, return, base type, */
/* 1280 */	NdrFcShort( 0x8 ),	/* x86 Stack size/offset = 8 */
/* 1282 */	0x8,		/* FC_LONG */
			0x0,		/* 0 */

	/* Procedure put_AudioRoute */

/* 1284 */	0x33,		/* FC_AUTO_HANDLE */
			0x6c,		/* Old Flags:  object, Oi2 */
/* 1286 */	NdrFcLong( 0x0 ),	/* 0 */
/* 1290 */	NdrFcShort( 0x16 ),	/* 22 */
/* 1292 */	NdrFcShort( 0xc ),	/* x86 Stack size/offset = 12 */
/* 1294 */	NdrFcShort( 0x8 ),	/* 8 */
/* 1296 */	NdrFcShort( 0x8 ),	/* 8 */
/* 1298 */	0x44,		/* Oi2 Flags:  has return, has ext, */
			0x2,		/* 2 */
/* 1300 */	0x8,		/* 8 */
			0x1,		/* Ext Flags:  new corr desc, */
/* 1302 */	NdrFcShort( 0x0 ),	/* 0 */
/* 1304 */	NdrFcShort( 0x0 ),	/* 0 */
/* 1306 */	NdrFcShort( 0x0 ),	/* 0 */

	/* Parameter newRoute */

/* 1308 */	NdrFcShort( 0x48 ),	/* Flags:  in, base type, */
/* 1310 */	NdrFcShort( 0x4 ),	/* x86 Stack size/offset = 4 */
/* 1312 */	0xe,		/* FC_ENUM32 */
			0x0,		/* 0 */

	/* Return value */

/* 1314 */	NdrFcShort( 0x70 ),	/* Flags:  out, return, base type, */
/* 1316 */	NdrFcShort( 0x8 ),	/* x86 Stack size/offset = 8 */
/* 1318 */	0x8,		/* FC_LONG */
			0x0,		/* 0 */

	/* Procedure get_OtherPartyName */

/* 1320 */	0x33,		/* FC_AUTO_HANDLE */
			0x6c,		/* Old Flags:  object, Oi2 */
/* 1322 */	NdrFcLong( 0x0 ),	/* 0 */
/* 1326 */	NdrFcShort( 0x17 ),	/* 23 */
/* 1328 */	NdrFcShort( 0xc ),	/* x86 Stack size/offset = 12 */
/* 1330 */	NdrFcShort( 0x0 ),	/* 0 */
/* 1332 */	NdrFcShort( 0x8 ),	/* 8 */
/* 1334 */	0x45,		/* Oi2 Flags:  srv must size, has return, has ext, */
			0x2,		/* 2 */
/* 1336 */	0x8,		/* 8 */
			0x3,		/* Ext Flags:  new corr desc, clt corr check, */
/* 1338 */	NdrFcShort( 0x1 ),	/* 1 */
/* 1340 */	NdrFcShort( 0x0 ),	/* 0 */
/* 1342 */	NdrFcShort( 0x0 ),	/* 0 */

	/* Parameter __returnValue */

/* 1344 */	NdrFcShort( 0x2113 ),	/* Flags:  must size, must free, out, simple ref, srv alloc size=8 */
/* 1346 */	NdrFcShort( 0x4 ),	/* x86 Stack size/offset = 4 */
/* 1348 */	NdrFcShort( 0xb0 ),	/* Type Offset=176 */

	/* Return value */

/* 1350 */	NdrFcShort( 0x70 ),	/* Flags:  out, return, base type, */
/* 1352 */	NdrFcShort( 0x8 ),	/* x86 Stack size/offset = 8 */
/* 1354 */	0x8,		/* FC_LONG */
			0x0,		/* 0 */

	/* Procedure get_OtherPartyNumber */

/* 1356 */	0x33,		/* FC_AUTO_HANDLE */
			0x6c,		/* Old Flags:  object, Oi2 */
/* 1358 */	NdrFcLong( 0x0 ),	/* 0 */
/* 1362 */	NdrFcShort( 0x18 ),	/* 24 */
/* 1364 */	NdrFcShort( 0xc ),	/* x86 Stack size/offset = 12 */
/* 1366 */	NdrFcShort( 0x0 ),	/* 0 */
/* 1368 */	NdrFcShort( 0x8 ),	/* 8 */
/* 1370 */	0x45,		/* Oi2 Flags:  srv must size, has return, has ext, */
			0x2,		/* 2 */
/* 1372 */	0x8,		/* 8 */
			0x3,		/* Ext Flags:  new corr desc, clt corr check, */
/* 1374 */	NdrFcShort( 0x1 ),	/* 1 */
/* 1376 */	NdrFcShort( 0x0 ),	/* 0 */
/* 1378 */	NdrFcShort( 0x0 ),	/* 0 */

	/* Parameter __returnValue */

/* 1380 */	NdrFcShort( 0x2113 ),	/* Flags:  must size, must free, out, simple ref, srv alloc size=8 */
/* 1382 */	NdrFcShort( 0x4 ),	/* x86 Stack size/offset = 4 */
/* 1384 */	NdrFcShort( 0xb0 ),	/* Type Offset=176 */

	/* Return value */

/* 1386 */	NdrFcShort( 0x70 ),	/* Flags:  out, return, base type, */
/* 1388 */	NdrFcShort( 0x8 ),	/* x86 Stack size/offset = 8 */
/* 1390 */	0x8,		/* FC_LONG */
			0x0,		/* 0 */

	/* Procedure get_CallStartTime */

/* 1392 */	0x33,		/* FC_AUTO_HANDLE */
			0x6c,		/* Old Flags:  object, Oi2 */
/* 1394 */	NdrFcLong( 0x0 ),	/* 0 */
/* 1398 */	NdrFcShort( 0x19 ),	/* 25 */
/* 1400 */	NdrFcShort( 0xc ),	/* x86 Stack size/offset = 12 */
/* 1402 */	NdrFcShort( 0x0 ),	/* 0 */
/* 1404 */	NdrFcShort( 0x34 ),	/* 52 */
/* 1406 */	0x44,		/* Oi2 Flags:  has return, has ext, */
			0x2,		/* 2 */
/* 1408 */	0x8,		/* 8 */
			0x1,		/* Ext Flags:  new corr desc, */
/* 1410 */	NdrFcShort( 0x0 ),	/* 0 */
/* 1412 */	NdrFcShort( 0x0 ),	/* 0 */
/* 1414 */	NdrFcShort( 0x0 ),	/* 0 */

	/* Parameter __returnValue */

/* 1416 */	NdrFcShort( 0x2112 ),	/* Flags:  must free, out, simple ref, srv alloc size=8 */
/* 1418 */	NdrFcShort( 0x4 ),	/* x86 Stack size/offset = 4 */
/* 1420 */	NdrFcShort( 0x2e ),	/* Type Offset=46 */

	/* Return value */

/* 1422 */	NdrFcShort( 0x70 ),	/* Flags:  out, return, base type, */
/* 1424 */	NdrFcShort( 0x8 ),	/* x86 Stack size/offset = 8 */
/* 1426 */	0x8,		/* FC_LONG */
			0x0,		/* 0 */

	/* Procedure Start */

/* 1428 */	0x33,		/* FC_AUTO_HANDLE */
			0x6c,		/* Old Flags:  object, Oi2 */
/* 1430 */	NdrFcLong( 0x0 ),	/* 0 */
/* 1434 */	NdrFcShort( 0x6 ),	/* 6 */
/* 1436 */	NdrFcShort( 0x8 ),	/* x86 Stack size/offset = 8 */
/* 1438 */	NdrFcShort( 0x0 ),	/* 0 */
/* 1440 */	NdrFcShort( 0x8 ),	/* 8 */
/* 1442 */	0x44,		/* Oi2 Flags:  has return, has ext, */
			0x1,		/* 1 */
/* 1444 */	0x8,		/* 8 */
			0x1,		/* Ext Flags:  new corr desc, */
/* 1446 */	NdrFcShort( 0x0 ),	/* 0 */
/* 1448 */	NdrFcShort( 0x0 ),	/* 0 */
/* 1450 */	NdrFcShort( 0x0 ),	/* 0 */

	/* Return value */

/* 1452 */	NdrFcShort( 0x70 ),	/* Flags:  out, return, base type, */
/* 1454 */	NdrFcShort( 0x4 ),	/* x86 Stack size/offset = 4 */
/* 1456 */	0x8,		/* FC_LONG */
			0x0,		/* 0 */

	/* Procedure StartServer */

/* 1458 */	0x33,		/* FC_AUTO_HANDLE */
			0x6c,		/* Old Flags:  object, Oi2 */
/* 1460 */	NdrFcLong( 0x0 ),	/* 0 */
/* 1464 */	NdrFcShort( 0x6 ),	/* 6 */
/* 1466 */	NdrFcShort( 0x10 ),	/* x86 Stack size/offset = 16 */
/* 1468 */	NdrFcShort( 0x8 ),	/* 8 */
/* 1470 */	NdrFcShort( 0x8 ),	/* 8 */
/* 1472 */	0x46,		/* Oi2 Flags:  clt must size, has return, has ext, */
			0x3,		/* 3 */
/* 1474 */	0x8,		/* 8 */
			0x5,		/* Ext Flags:  new corr desc, srv corr check, */
/* 1476 */	NdrFcShort( 0x0 ),	/* 0 */
/* 1478 */	NdrFcShort( 0x1 ),	/* 1 */
/* 1480 */	NdrFcShort( 0x0 ),	/* 0 */

	/* Parameter __outOfProcServerClassNamesSize */

/* 1482 */	NdrFcShort( 0x48 ),	/* Flags:  in, base type, */
/* 1484 */	NdrFcShort( 0x4 ),	/* x86 Stack size/offset = 4 */
/* 1486 */	0x8,		/* FC_LONG */
			0x0,		/* 0 */

	/* Parameter outOfProcServerClassNames */

/* 1488 */	NdrFcShort( 0x10b ),	/* Flags:  must size, must free, in, simple ref, */
/* 1490 */	NdrFcShort( 0x8 ),	/* x86 Stack size/offset = 8 */
/* 1492 */	NdrFcShort( 0xbe ),	/* Type Offset=190 */

	/* Return value */

/* 1494 */	NdrFcShort( 0x70 ),	/* Flags:  out, return, base type, */
/* 1496 */	NdrFcShort( 0xc ),	/* x86 Stack size/offset = 12 */
/* 1498 */	0x8,		/* FC_LONG */
			0x0,		/* 0 */

	/* Procedure get_CallController */

/* 1500 */	0x33,		/* FC_AUTO_HANDLE */
			0x6c,		/* Old Flags:  object, Oi2 */
/* 1502 */	NdrFcLong( 0x0 ),	/* 0 */
/* 1506 */	NdrFcShort( 0x8 ),	/* 8 */
/* 1508 */	NdrFcShort( 0xc ),	/* x86 Stack size/offset = 12 */
/* 1510 */	NdrFcShort( 0x0 ),	/* 0 */
/* 1512 */	NdrFcShort( 0x8 ),	/* 8 */
/* 1514 */	0x45,		/* Oi2 Flags:  srv must size, has return, has ext, */
			0x2,		/* 2 */
/* 1516 */	0x8,		/* 8 */
			0x1,		/* Ext Flags:  new corr desc, */
/* 1518 */	NdrFcShort( 0x0 ),	/* 0 */
/* 1520 */	NdrFcShort( 0x0 ),	/* 0 */
/* 1522 */	NdrFcShort( 0x0 ),	/* 0 */

	/* Parameter __returnValue */

/* 1524 */	NdrFcShort( 0x13 ),	/* Flags:  must size, must free, out, */
/* 1526 */	NdrFcShort( 0x4 ),	/* x86 Stack size/offset = 4 */
/* 1528 */	NdrFcShort( 0xd4 ),	/* Type Offset=212 */

	/* Return value */

/* 1530 */	NdrFcShort( 0x70 ),	/* Flags:  out, return, base type, */
/* 1532 */	NdrFcShort( 0x8 ),	/* x86 Stack size/offset = 8 */
/* 1534 */	0x8,		/* FC_LONG */
			0x0,		/* 0 */

	/* Procedure get_VideoRenderer */

/* 1536 */	0x33,		/* FC_AUTO_HANDLE */
			0x6c,		/* Old Flags:  object, Oi2 */
/* 1538 */	NdrFcLong( 0x0 ),	/* 0 */
/* 1542 */	NdrFcShort( 0x9 ),	/* 9 */
/* 1544 */	NdrFcShort( 0xc ),	/* x86 Stack size/offset = 12 */
/* 1546 */	NdrFcShort( 0x0 ),	/* 0 */
/* 1548 */	NdrFcShort( 0x8 ),	/* 8 */
/* 1550 */	0x45,		/* Oi2 Flags:  srv must size, has return, has ext, */
			0x2,		/* 2 */
/* 1552 */	0x8,		/* 8 */
			0x1,		/* Ext Flags:  new corr desc, */
/* 1554 */	NdrFcShort( 0x0 ),	/* 0 */
/* 1556 */	NdrFcShort( 0x0 ),	/* 0 */
/* 1558 */	NdrFcShort( 0x0 ),	/* 0 */

	/* Parameter __returnValue */

/* 1560 */	NdrFcShort( 0x13 ),	/* Flags:  must size, must free, out, */
/* 1562 */	NdrFcShort( 0x4 ),	/* x86 Stack size/offset = 4 */
/* 1564 */	NdrFcShort( 0xea ),	/* Type Offset=234 */

	/* Return value */

/* 1566 */	NdrFcShort( 0x70 ),	/* Flags:  out, return, base type, */
/* 1568 */	NdrFcShort( 0x8 ),	/* x86 Stack size/offset = 8 */
/* 1570 */	0x8,		/* FC_LONG */
			0x0,		/* 0 */

	/* Procedure put_VideoRenderer */

/* 1572 */	0x33,		/* FC_AUTO_HANDLE */
			0x6c,		/* Old Flags:  object, Oi2 */
/* 1574 */	NdrFcLong( 0x0 ),	/* 0 */
/* 1578 */	NdrFcShort( 0xa ),	/* 10 */
/* 1580 */	NdrFcShort( 0xc ),	/* x86 Stack size/offset = 12 */
/* 1582 */	NdrFcShort( 0x0 ),	/* 0 */
/* 1584 */	NdrFcShort( 0x8 ),	/* 8 */
/* 1586 */	0x46,		/* Oi2 Flags:  clt must size, has return, has ext, */
			0x2,		/* 2 */
/* 1588 */	0x8,		/* 8 */
			0x1,		/* Ext Flags:  new corr desc, */
/* 1590 */	NdrFcShort( 0x0 ),	/* 0 */
/* 1592 */	NdrFcShort( 0x0 ),	/* 0 */
/* 1594 */	NdrFcShort( 0x0 ),	/* 0 */

	/* Parameter value */

/* 1596 */	NdrFcShort( 0xb ),	/* Flags:  must size, must free, in, */
/* 1598 */	NdrFcShort( 0x4 ),	/* x86 Stack size/offset = 4 */
/* 1600 */	NdrFcShort( 0xee ),	/* Type Offset=238 */

	/* Return value */

/* 1602 */	NdrFcShort( 0x70 ),	/* Flags:  out, return, base type, */
/* 1604 */	NdrFcShort( 0x8 ),	/* x86 Stack size/offset = 8 */
/* 1606 */	0x8,		/* FC_LONG */
			0x0,		/* 0 */

	/* Procedure get_AudioController */

/* 1608 */	0x33,		/* FC_AUTO_HANDLE */
			0x6c,		/* Old Flags:  object, Oi2 */
/* 1610 */	NdrFcLong( 0x0 ),	/* 0 */
/* 1614 */	NdrFcShort( 0xb ),	/* 11 */
/* 1616 */	NdrFcShort( 0xc ),	/* x86 Stack size/offset = 12 */
/* 1618 */	NdrFcShort( 0x0 ),	/* 0 */
/* 1620 */	NdrFcShort( 0x8 ),	/* 8 */
/* 1622 */	0x45,		/* Oi2 Flags:  srv must size, has return, has ext, */
			0x2,		/* 2 */
/* 1624 */	0x8,		/* 8 */
			0x1,		/* Ext Flags:  new corr desc, */
/* 1626 */	NdrFcShort( 0x0 ),	/* 0 */
/* 1628 */	NdrFcShort( 0x0 ),	/* 0 */
/* 1630 */	NdrFcShort( 0x0 ),	/* 0 */

	/* Parameter __returnValue */

/* 1632 */	NdrFcShort( 0x13 ),	/* Flags:  must size, must free, out, */
/* 1634 */	NdrFcShort( 0x4 ),	/* x86 Stack size/offset = 4 */
/* 1636 */	NdrFcShort( 0x100 ),	/* Type Offset=256 */

	/* Return value */

/* 1638 */	NdrFcShort( 0x70 ),	/* Flags:  out, return, base type, */
/* 1640 */	NdrFcShort( 0x8 ),	/* x86 Stack size/offset = 8 */
/* 1642 */	0x8,		/* FC_LONG */
			0x0,		/* 0 */

	/* Procedure get_CaptureController */

/* 1644 */	0x33,		/* FC_AUTO_HANDLE */
			0x6c,		/* Old Flags:  object, Oi2 */
/* 1646 */	NdrFcLong( 0x0 ),	/* 0 */
/* 1650 */	NdrFcShort( 0xc ),	/* 12 */
/* 1652 */	NdrFcShort( 0xc ),	/* x86 Stack size/offset = 12 */
/* 1654 */	NdrFcShort( 0x0 ),	/* 0 */
/* 1656 */	NdrFcShort( 0x8 ),	/* 8 */
/* 1658 */	0x45,		/* Oi2 Flags:  srv must size, has return, has ext, */
			0x2,		/* 2 */
/* 1660 */	0x8,		/* 8 */
			0x1,		/* Ext Flags:  new corr desc, */
/* 1662 */	NdrFcShort( 0x0 ),	/* 0 */
/* 1664 */	NdrFcShort( 0x0 ),	/* 0 */
/* 1666 */	NdrFcShort( 0x0 ),	/* 0 */

	/* Parameter __returnValue */

/* 1668 */	NdrFcShort( 0x13 ),	/* Flags:  must size, must free, out, */
/* 1670 */	NdrFcShort( 0x4 ),	/* x86 Stack size/offset = 4 */
/* 1672 */	NdrFcShort( 0x116 ),	/* Type Offset=278 */

	/* Return value */

/* 1674 */	NdrFcShort( 0x70 ),	/* Flags:  out, return, base type, */
/* 1676 */	NdrFcShort( 0x8 ),	/* x86 Stack size/offset = 8 */
/* 1678 */	0x8,		/* FC_LONG */
			0x0,		/* 0 */

	/* Procedure get_TransportController */

/* 1680 */	0x33,		/* FC_AUTO_HANDLE */
			0x6c,		/* Old Flags:  object, Oi2 */
/* 1682 */	NdrFcLong( 0x0 ),	/* 0 */
/* 1686 */	NdrFcShort( 0xd ),	/* 13 */
/* 1688 */	NdrFcShort( 0xc ),	/* x86 Stack size/offset = 12 */
/* 1690 */	NdrFcShort( 0x0 ),	/* 0 */
/* 1692 */	NdrFcShort( 0x8 ),	/* 8 */
/* 1694 */	0x45,		/* Oi2 Flags:  srv must size, has return, has ext, */
			0x2,		/* 2 */
/* 1696 */	0x8,		/* 8 */
			0x1,		/* Ext Flags:  new corr desc, */
/* 1698 */	NdrFcShort( 0x0 ),	/* 0 */
/* 1700 */	NdrFcShort( 0x0 ),	/* 0 */
/* 1702 */	NdrFcShort( 0x0 ),	/* 0 */

	/* Parameter __returnValue */

/* 1704 */	NdrFcShort( 0x13 ),	/* Flags:  must size, must free, out, */
/* 1706 */	NdrFcShort( 0x4 ),	/* x86 Stack size/offset = 4 */
/* 1708 */	NdrFcShort( 0x12c ),	/* Type Offset=300 */

	/* Return value */

/* 1710 */	NdrFcShort( 0x70 ),	/* Flags:  out, return, base type, */
/* 1712 */	NdrFcShort( 0x8 ),	/* x86 Stack size/offset = 8 */
/* 1714 */	0x8,		/* FC_LONG */
			0x0,		/* 0 */

	/* Procedure GetCurrentProcessId */

/* 1716 */	0x33,		/* FC_AUTO_HANDLE */
			0x6c,		/* Old Flags:  object, Oi2 */
/* 1718 */	NdrFcLong( 0x0 ),	/* 0 */
/* 1722 */	NdrFcShort( 0x6 ),	/* 6 */
/* 1724 */	NdrFcShort( 0xc ),	/* x86 Stack size/offset = 12 */
/* 1726 */	NdrFcShort( 0x0 ),	/* 0 */
/* 1728 */	NdrFcShort( 0x24 ),	/* 36 */
/* 1730 */	0x44,		/* Oi2 Flags:  has return, has ext, */
			0x2,		/* 2 */
/* 1732 */	0x8,		/* 8 */
			0x1,		/* Ext Flags:  new corr desc, */
/* 1734 */	NdrFcShort( 0x0 ),	/* 0 */
/* 1736 */	NdrFcShort( 0x0 ),	/* 0 */
/* 1738 */	NdrFcShort( 0x0 ),	/* 0 */

	/* Parameter __returnValue */

/* 1740 */	NdrFcShort( 0x2150 ),	/* Flags:  out, base type, simple ref, srv alloc size=8 */
/* 1742 */	NdrFcShort( 0x4 ),	/* x86 Stack size/offset = 4 */
/* 1744 */	0x8,		/* FC_LONG */
			0x0,		/* 0 */

	/* Return value */

/* 1746 */	NdrFcShort( 0x70 ),	/* Flags:  out, return, base type, */
/* 1748 */	NdrFcShort( 0x8 ),	/* x86 Stack size/offset = 8 */
/* 1750 */	0x8,		/* FC_LONG */
			0x0,		/* 0 */

	/* Procedure GetUiDisconnectedEventName */

/* 1752 */	0x33,		/* FC_AUTO_HANDLE */
			0x6c,		/* Old Flags:  object, Oi2 */
/* 1754 */	NdrFcLong( 0x0 ),	/* 0 */
/* 1758 */	NdrFcShort( 0x7 ),	/* 7 */
/* 1760 */	NdrFcShort( 0x10 ),	/* x86 Stack size/offset = 16 */
/* 1762 */	NdrFcShort( 0x8 ),	/* 8 */
/* 1764 */	NdrFcShort( 0x8 ),	/* 8 */
/* 1766 */	0x45,		/* Oi2 Flags:  srv must size, has return, has ext, */
			0x3,		/* 3 */
/* 1768 */	0x8,		/* 8 */
			0x3,		/* Ext Flags:  new corr desc, clt corr check, */
/* 1770 */	NdrFcShort( 0x1 ),	/* 1 */
/* 1772 */	NdrFcShort( 0x0 ),	/* 0 */
/* 1774 */	NdrFcShort( 0x0 ),	/* 0 */

	/* Parameter backgroundProcessId */

/* 1776 */	NdrFcShort( 0x48 ),	/* Flags:  in, base type, */
/* 1778 */	NdrFcShort( 0x4 ),	/* x86 Stack size/offset = 4 */
/* 1780 */	0x8,		/* FC_LONG */
			0x0,		/* 0 */

	/* Parameter __returnValue */

/* 1782 */	NdrFcShort( 0x2113 ),	/* Flags:  must size, must free, out, simple ref, srv alloc size=8 */
/* 1784 */	NdrFcShort( 0x8 ),	/* x86 Stack size/offset = 8 */
/* 1786 */	NdrFcShort( 0xb0 ),	/* Type Offset=176 */

	/* Return value */

/* 1788 */	NdrFcShort( 0x70 ),	/* Flags:  out, return, base type, */
/* 1790 */	NdrFcShort( 0xc ),	/* x86 Stack size/offset = 12 */
/* 1792 */	0x8,		/* FC_LONG */
			0x0,		/* 0 */

	/* Procedure GetBackgroundProcessReadyEventName */

/* 1794 */	0x33,		/* FC_AUTO_HANDLE */
			0x6c,		/* Old Flags:  object, Oi2 */
/* 1796 */	NdrFcLong( 0x0 ),	/* 0 */
/* 1800 */	NdrFcShort( 0x8 ),	/* 8 */
/* 1802 */	NdrFcShort( 0x10 ),	/* x86 Stack size/offset = 16 */
/* 1804 */	NdrFcShort( 0x8 ),	/* 8 */
/* 1806 */	NdrFcShort( 0x8 ),	/* 8 */
/* 1808 */	0x45,		/* Oi2 Flags:  srv must size, has return, has ext, */
			0x3,		/* 3 */
/* 1810 */	0x8,		/* 8 */
			0x3,		/* Ext Flags:  new corr desc, clt corr check, */
/* 1812 */	NdrFcShort( 0x1 ),	/* 1 */
/* 1814 */	NdrFcShort( 0x0 ),	/* 0 */
/* 1816 */	NdrFcShort( 0x0 ),	/* 0 */

	/* Parameter backgroundProcessId */

/* 1818 */	NdrFcShort( 0x48 ),	/* Flags:  in, base type, */
/* 1820 */	NdrFcShort( 0x4 ),	/* x86 Stack size/offset = 4 */
/* 1822 */	0x8,		/* FC_LONG */
			0x0,		/* 0 */

	/* Parameter __returnValue */

/* 1824 */	NdrFcShort( 0x2113 ),	/* Flags:  must size, must free, out, simple ref, srv alloc size=8 */
/* 1826 */	NdrFcShort( 0x8 ),	/* x86 Stack size/offset = 8 */
/* 1828 */	NdrFcShort( 0xb0 ),	/* Type Offset=176 */

	/* Return value */

/* 1830 */	NdrFcShort( 0x70 ),	/* Flags:  out, return, base type, */
/* 1832 */	NdrFcShort( 0xc ),	/* x86 Stack size/offset = 12 */
/* 1834 */	0x8,		/* FC_LONG */
			0x0,		/* 0 */

	/* Procedure get_Instance */

/* 1836 */	0x33,		/* FC_AUTO_HANDLE */
			0x6c,		/* Old Flags:  object, Oi2 */
/* 1838 */	NdrFcLong( 0x0 ),	/* 0 */
/* 1842 */	NdrFcShort( 0x9 ),	/* 9 */
/* 1844 */	NdrFcShort( 0xc ),	/* x86 Stack size/offset = 12 */
/* 1846 */	NdrFcShort( 0x0 ),	/* 0 */
/* 1848 */	NdrFcShort( 0x8 ),	/* 8 */
/* 1850 */	0x45,		/* Oi2 Flags:  srv must size, has return, has ext, */
			0x2,		/* 2 */
/* 1852 */	0x8,		/* 8 */
			0x1,		/* Ext Flags:  new corr desc, */
/* 1854 */	NdrFcShort( 0x0 ),	/* 0 */
/* 1856 */	NdrFcShort( 0x0 ),	/* 0 */
/* 1858 */	NdrFcShort( 0x0 ),	/* 0 */

	/* Parameter __returnValue */

/* 1860 */	NdrFcShort( 0x13 ),	/* Flags:  must size, must free, out, */
/* 1862 */	NdrFcShort( 0x4 ),	/* x86 Stack size/offset = 4 */
/* 1864 */	NdrFcShort( 0x134 ),	/* Type Offset=308 */

	/* Return value */

/* 1866 */	NdrFcShort( 0x70 ),	/* Flags:  out, return, base type, */
/* 1868 */	NdrFcShort( 0x8 ),	/* x86 Stack size/offset = 8 */
/* 1870 */	0x8,		/* FC_LONG */
			0x0,		/* 0 */

			0x0
        }
    };

static const PhoneVoIPApp2EBackEnd_MIDL_TYPE_FORMAT_STRING PhoneVoIPApp2EBackEnd__MIDL_TypeFormatString =
    {
        0,
        {
			NdrFcShort( 0x0 ),	/* 0 */
/*  2 */	
			0x2f,		/* FC_IP */
			0x5a,		/* FC_CONSTANT_IID */
/*  4 */	NdrFcLong( 0x905a0fe0 ),	/* -1873145888 */
/*  8 */	NdrFcShort( 0xbc53 ),	/* -17325 */
/* 10 */	NdrFcShort( 0x11df ),	/* 4575 */
/* 12 */	0x8c,		/* 140 */
			0x49,		/* 73 */
/* 14 */	0x0,		/* 0 */
			0x1e,		/* 30 */
/* 16 */	0x4f,		/* 79 */
			0xc6,		/* 198 */
/* 18 */	0x86,		/* 134 */
			0xda,		/* 218 */
/* 20 */	
			0x11, 0xc,	/* FC_RP [alloced_on_stack] [simple_pointer] */
/* 22 */	0x1,		/* FC_BYTE */
			0x5c,		/* FC_PAD */
/* 24 */	
			0x2f,		/* FC_IP */
			0x5a,		/* FC_CONSTANT_IID */
/* 26 */	NdrFcLong( 0xf2035e6a ),	/* -234660246 */
/* 30 */	NdrFcShort( 0x8067 ),	/* -32665 */
/* 32 */	NdrFcShort( 0x3abb ),	/* 15035 */
/* 34 */	0xa7,		/* 167 */
			0x95,		/* 149 */
/* 36 */	0x7b,		/* 123 */
			0x33,		/* 51 */
/* 38 */	0x4c,		/* 76 */
			0x67,		/* 103 */
/* 40 */	0xa2,		/* 162 */
			0xed,		/* 237 */
/* 42 */	
			0x11, 0x4,	/* FC_RP [alloced_on_stack] */
/* 44 */	NdrFcShort( 0x2 ),	/* Offset= 2 (46) */
/* 46 */	
			0x15,		/* FC_STRUCT */
			0x7,		/* 7 */
/* 48 */	NdrFcShort( 0x8 ),	/* 8 */
/* 50 */	0xb,		/* FC_HYPER */
			0x5b,		/* FC_END */
/* 52 */	
			0x2f,		/* FC_IP */
			0x5a,		/* FC_CONSTANT_IID */
/* 54 */	NdrFcLong( 0xf5a3c2ae ),	/* -173817170 */
/* 58 */	NdrFcShort( 0xef7b ),	/* -4229 */
/* 60 */	NdrFcShort( 0x3de2 ),	/* 15842 */
/* 62 */	0x8b,		/* 139 */
			0xe,		/* 14 */
/* 64 */	0x8e,		/* 142 */
			0x8b,		/* 139 */
/* 66 */	0x3c,		/* 60 */
			0xd2,		/* 210 */
/* 68 */	0xd,		/* 13 */
			0x9d,		/* 157 */
/* 70 */	
			0x2f,		/* FC_IP */
			0x5a,		/* FC_CONSTANT_IID */
/* 72 */	NdrFcLong( 0x1698b961 ),	/* 379107681 */
/* 76 */	NdrFcShort( 0xf90e ),	/* -1778 */
/* 78 */	NdrFcShort( 0x30d0 ),	/* 12496 */
/* 80 */	0x80,		/* 128 */
			0xff,		/* 255 */
/* 82 */	0x22,		/* 34 */
			0xe9,		/* 233 */
/* 84 */	0x4c,		/* 76 */
			0xf6,		/* 246 */
/* 86 */	0x6d,		/* 109 */
			0x7b,		/* 123 */
/* 88 */	
			0x2f,		/* FC_IP */
			0x5a,		/* FC_CONSTANT_IID */
/* 90 */	NdrFcLong( 0x39126060 ),	/* 957505632 */
/* 94 */	NdrFcShort( 0x292 ),	/* 658 */
/* 96 */	NdrFcShort( 0x36d6 ),	/* 14038 */
/* 98 */	0xb3,		/* 179 */
			0xf8,		/* 248 */
/* 100 */	0x9a,		/* 154 */
			0xc4,		/* 196 */
/* 102 */	0x15,		/* 21 */
			0x6c,		/* 108 */
/* 104 */	0x65,		/* 101 */
			0x1d,		/* 29 */
/* 106 */	
			0x12, 0x0,	/* FC_UP */
/* 108 */	NdrFcShort( 0xe ),	/* Offset= 14 (122) */
/* 110 */	
			0x1b,		/* FC_CARRAY */
			0x1,		/* 1 */
/* 112 */	NdrFcShort( 0x2 ),	/* 2 */
/* 114 */	0x9,		/* Corr desc: FC_ULONG */
			0x0,		/*  */
/* 116 */	NdrFcShort( 0xfffc ),	/* -4 */
/* 118 */	NdrFcShort( 0x1 ),	/* Corr flags:  early, */
/* 120 */	0x6,		/* FC_SHORT */
			0x5b,		/* FC_END */
/* 122 */	
			0x17,		/* FC_CSTRUCT */
			0x3,		/* 3 */
/* 124 */	NdrFcShort( 0x8 ),	/* 8 */
/* 126 */	NdrFcShort( 0xfff0 ),	/* Offset= -16 (110) */
/* 128 */	0x8,		/* FC_LONG */
			0x8,		/* FC_LONG */
/* 130 */	0x5c,		/* FC_PAD */
			0x5b,		/* FC_END */
/* 132 */	0xb4,		/* FC_USER_MARSHAL */
			0x83,		/* 131 */
/* 134 */	NdrFcShort( 0x0 ),	/* 0 */
/* 136 */	NdrFcShort( 0x4 ),	/* 4 */
/* 138 */	NdrFcShort( 0x0 ),	/* 0 */
/* 140 */	NdrFcShort( 0xffde ),	/* Offset= -34 (106) */
/* 142 */	
			0x11, 0xc,	/* FC_RP [alloced_on_stack] [simple_pointer] */
/* 144 */	0x3,		/* FC_SMALL */
			0x5c,		/* FC_PAD */
/* 146 */	
			0x2f,		/* FC_IP */
			0x5a,		/* FC_CONSTANT_IID */
/* 148 */	NdrFcLong( 0x91ddee70 ),	/* -1847726480 */
/* 152 */	NdrFcShort( 0xaa90 ),	/* -21872 */
/* 154 */	NdrFcShort( 0x38e7 ),	/* 14567 */
/* 156 */	0xb4,		/* 180 */
			0xe5,		/* 229 */
/* 158 */	0xf7,		/* 247 */
			0x95,		/* 149 */
/* 160 */	0x95,		/* 149 */
			0x69,		/* 105 */
/* 162 */	0xcb,		/* 203 */
			0x5c,		/* 92 */
/* 164 */	
			0x11, 0xc,	/* FC_RP [alloced_on_stack] [simple_pointer] */
/* 166 */	0xe,		/* FC_ENUM32 */
			0x5c,		/* FC_PAD */
/* 168 */	
			0x11, 0x4,	/* FC_RP [alloced_on_stack] */
/* 170 */	NdrFcShort( 0x6 ),	/* Offset= 6 (176) */
/* 172 */	
			0x13, 0x0,	/* FC_OP */
/* 174 */	NdrFcShort( 0xffcc ),	/* Offset= -52 (122) */
/* 176 */	0xb4,		/* FC_USER_MARSHAL */
			0x83,		/* 131 */
/* 178 */	NdrFcShort( 0x0 ),	/* 0 */
/* 180 */	NdrFcShort( 0x4 ),	/* 4 */
/* 182 */	NdrFcShort( 0x0 ),	/* 0 */
/* 184 */	NdrFcShort( 0xfff4 ),	/* Offset= -12 (172) */
/* 186 */	
			0x11, 0x0,	/* FC_RP */
/* 188 */	NdrFcShort( 0x2 ),	/* Offset= 2 (190) */
/* 190 */	
			0x21,		/* FC_BOGUS_ARRAY */
			0x3,		/* 3 */
/* 192 */	NdrFcShort( 0x0 ),	/* 0 */
/* 194 */	0x29,		/* Corr desc:  parameter, FC_ULONG */
			0x0,		/*  */
/* 196 */	NdrFcShort( 0x4 ),	/* x86 Stack size/offset = 4 */
/* 198 */	NdrFcShort( 0x1 ),	/* Corr flags:  early, */
/* 200 */	NdrFcLong( 0xffffffff ),	/* -1 */
/* 204 */	NdrFcShort( 0x0 ),	/* Corr flags:  */
/* 206 */	0x4c,		/* FC_EMBEDDED_COMPLEX */
			0x0,		/* 0 */
/* 208 */	NdrFcShort( 0xffb4 ),	/* Offset= -76 (132) */
/* 210 */	0x5c,		/* FC_PAD */
			0x5b,		/* FC_END */
/* 212 */	
			0x11, 0x10,	/* FC_RP [pointer_deref] */
/* 214 */	NdrFcShort( 0x2 ),	/* Offset= 2 (216) */
/* 216 */	
			0x2f,		/* FC_IP */
			0x5a,		/* FC_CONSTANT_IID */
/* 218 */	NdrFcLong( 0x6b50718 ),	/* 112527128 */
/* 222 */	NdrFcShort( 0x3528 ),	/* 13608 */
/* 224 */	NdrFcShort( 0x3b66 ),	/* 15206 */
/* 226 */	0xbe,		/* 190 */
			0x76,		/* 118 */
/* 228 */	0xe1,		/* 225 */
			0x83,		/* 131 */
/* 230 */	0xaa,		/* 170 */
			0x80,		/* 128 */
/* 232 */	0xd4,		/* 212 */
			0xa5,		/* 165 */
/* 234 */	
			0x11, 0x10,	/* FC_RP [pointer_deref] */
/* 236 */	NdrFcShort( 0x2 ),	/* Offset= 2 (238) */
/* 238 */	
			0x2f,		/* FC_IP */
			0x5a,		/* FC_CONSTANT_IID */
/* 240 */	NdrFcLong( 0x6928ca7b ),	/* 1764280955 */
/* 244 */	NdrFcShort( 0x166d ),	/* 5741 */
/* 246 */	NdrFcShort( 0x3b37 ),	/* 15159 */
/* 248 */	0x90,		/* 144 */
			0x10,		/* 16 */
/* 250 */	0xfb,		/* 251 */
			0xab,		/* 171 */
/* 252 */	0x2c,		/* 44 */
			0x7e,		/* 126 */
/* 254 */	0x92,		/* 146 */
			0xb0,		/* 176 */
/* 256 */	
			0x11, 0x10,	/* FC_RP [pointer_deref] */
/* 258 */	NdrFcShort( 0x2 ),	/* Offset= 2 (260) */
/* 260 */	
			0x2f,		/* FC_IP */
			0x5a,		/* FC_CONSTANT_IID */
/* 262 */	NdrFcLong( 0xde465431 ),	/* -565816271 */
/* 266 */	NdrFcShort( 0xed24 ),	/* -4828 */
/* 268 */	NdrFcShort( 0x3298 ),	/* 12952 */
/* 270 */	0xa1,		/* 161 */
			0x87,		/* 135 */
/* 272 */	0x8f,		/* 143 */
			0x1a,		/* 26 */
/* 274 */	0xfb,		/* 251 */
			0xbb,		/* 187 */
/* 276 */	0xe1,		/* 225 */
			0x35,		/* 53 */
/* 278 */	
			0x11, 0x10,	/* FC_RP [pointer_deref] */
/* 280 */	NdrFcShort( 0x2 ),	/* Offset= 2 (282) */
/* 282 */	
			0x2f,		/* FC_IP */
			0x5a,		/* FC_CONSTANT_IID */
/* 284 */	NdrFcLong( 0x8313dbea ),	/* -2095850518 */
/* 288 */	NdrFcShort( 0xfd3b ),	/* -709 */
/* 290 */	NdrFcShort( 0x3071 ),	/* 12401 */
/* 292 */	0x80,		/* 128 */
			0x35,		/* 53 */
/* 294 */	0x7b,		/* 123 */
			0x61,		/* 97 */
/* 296 */	0x16,		/* 22 */
			0x58,		/* 88 */
/* 298 */	0xda,		/* 218 */
			0xd8,		/* 216 */
/* 300 */	
			0x11, 0x10,	/* FC_RP [pointer_deref] */
/* 302 */	NdrFcShort( 0xff06 ),	/* Offset= -250 (52) */
/* 304 */	
			0x11, 0xc,	/* FC_RP [alloced_on_stack] [simple_pointer] */
/* 306 */	0x8,		/* FC_LONG */
			0x5c,		/* FC_PAD */
/* 308 */	
			0x11, 0x10,	/* FC_RP [pointer_deref] */
/* 310 */	NdrFcShort( 0x2 ),	/* Offset= 2 (312) */
/* 312 */	
			0x2f,		/* FC_IP */
			0x5a,		/* FC_CONSTANT_IID */
/* 314 */	NdrFcLong( 0xc8afe1a8 ),	/* -927997528 */
/* 318 */	NdrFcShort( 0x92fc ),	/* -27908 */
/* 320 */	NdrFcShort( 0x3783 ),	/* 14211 */
/* 322 */	0x95,		/* 149 */
			0x20,		/* 32 */
/* 324 */	0xd6,		/* 214 */
			0xbb,		/* 187 */
/* 326 */	0xc5,		/* 197 */
			0x7,		/* 7 */
/* 328 */	0xb2,		/* 178 */
			0x4a,		/* 74 */

			0x0
        }
    };

static const USER_MARSHAL_ROUTINE_QUADRUPLE UserMarshalRoutines[ WIRE_MARSHAL_TABLE_SIZE ] = 
        {
            
            {
            HSTRING_UserSize
            ,HSTRING_UserMarshal
            ,HSTRING_UserUnmarshal
            ,HSTRING_UserFree
            }

        };



/* Standard interface: __MIDL_itf_PhoneVoIPApp2EBackEnd_0000_0000, ver. 0.0,
   GUID={0x00000000,0x0000,0x0000,{0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00}} */


/* Object interface: IUnknown, ver. 0.0,
   GUID={0x00000000,0x0000,0x0000,{0xC0,0x00,0x00,0x00,0x00,0x00,0x00,0x46}} */


/* Object interface: __x_ABI_CPhoneVoIPApp_CBackEnd_CIMessageReceivedEventHandler, ver. 0.0,
   GUID={0xF2035E6A,0x8067,0x3ABB,{0xA7,0x95,0x7B,0x33,0x4C,0x67,0xA2,0xED}} */

#pragma code_seg(".orpc")
static const unsigned short __x_ABI_CPhoneVoIPApp_CBackEnd_CIMessageReceivedEventHandler_FormatStringOffsetTable[] =
    {
    0
    };

static const MIDL_STUBLESS_PROXY_INFO __x_ABI_CPhoneVoIPApp_CBackEnd_CIMessageReceivedEventHandler_ProxyInfo =
    {
    &Object_StubDesc,
    PhoneVoIPApp2EBackEnd__MIDL_ProcFormatString.Format,
    &__x_ABI_CPhoneVoIPApp_CBackEnd_CIMessageReceivedEventHandler_FormatStringOffsetTable[-3],
    0,
    0,
    0
    };


static const MIDL_SERVER_INFO __x_ABI_CPhoneVoIPApp_CBackEnd_CIMessageReceivedEventHandler_ServerInfo = 
    {
    &Object_StubDesc,
    0,
    PhoneVoIPApp2EBackEnd__MIDL_ProcFormatString.Format,
    &__x_ABI_CPhoneVoIPApp_CBackEnd_CIMessageReceivedEventHandler_FormatStringOffsetTable[-3],
    0,
    0,
    0,
    0};
CINTERFACE_PROXY_VTABLE(4) ___x_ABI_CPhoneVoIPApp_CBackEnd_CIMessageReceivedEventHandlerProxyVtbl = 
{
    &__x_ABI_CPhoneVoIPApp_CBackEnd_CIMessageReceivedEventHandler_ProxyInfo,
    &IID___x_ABI_CPhoneVoIPApp_CBackEnd_CIMessageReceivedEventHandler,
    IUnknown_QueryInterface_Proxy,
    IUnknown_AddRef_Proxy,
    IUnknown_Release_Proxy ,
    (void *) (INT_PTR) -1 /* __x_ABI_CPhoneVoIPApp_CBackEnd_CIMessageReceivedEventHandler::Invoke */
};

const CInterfaceStubVtbl ___x_ABI_CPhoneVoIPApp_CBackEnd_CIMessageReceivedEventHandlerStubVtbl =
{
    &IID___x_ABI_CPhoneVoIPApp_CBackEnd_CIMessageReceivedEventHandler,
    &__x_ABI_CPhoneVoIPApp_CBackEnd_CIMessageReceivedEventHandler_ServerInfo,
    4,
    0, /* pure interpreted */
    CStdStubBuffer_METHODS
};


/* Object interface: __x_ABI_CPhoneVoIPApp_CBackEnd_CICameraLocationChangedEventHandler, ver. 0.0,
   GUID={0x1698B961,0xF90E,0x30D0,{0x80,0xFF,0x22,0xE9,0x4C,0xF6,0x6D,0x7B}} */

#pragma code_seg(".orpc")
static const unsigned short __x_ABI_CPhoneVoIPApp_CBackEnd_CICameraLocationChangedEventHandler_FormatStringOffsetTable[] =
    {
    48
    };

static const MIDL_STUBLESS_PROXY_INFO __x_ABI_CPhoneVoIPApp_CBackEnd_CICameraLocationChangedEventHandler_ProxyInfo =
    {
    &Object_StubDesc,
    PhoneVoIPApp2EBackEnd__MIDL_ProcFormatString.Format,
    &__x_ABI_CPhoneVoIPApp_CBackEnd_CICameraLocationChangedEventHandler_FormatStringOffsetTable[-3],
    0,
    0,
    0
    };


static const MIDL_SERVER_INFO __x_ABI_CPhoneVoIPApp_CBackEnd_CICameraLocationChangedEventHandler_ServerInfo = 
    {
    &Object_StubDesc,
    0,
    PhoneVoIPApp2EBackEnd__MIDL_ProcFormatString.Format,
    &__x_ABI_CPhoneVoIPApp_CBackEnd_CICameraLocationChangedEventHandler_FormatStringOffsetTable[-3],
    0,
    0,
    0,
    0};
CINTERFACE_PROXY_VTABLE(4) ___x_ABI_CPhoneVoIPApp_CBackEnd_CICameraLocationChangedEventHandlerProxyVtbl = 
{
    &__x_ABI_CPhoneVoIPApp_CBackEnd_CICameraLocationChangedEventHandler_ProxyInfo,
    &IID___x_ABI_CPhoneVoIPApp_CBackEnd_CICameraLocationChangedEventHandler,
    IUnknown_QueryInterface_Proxy,
    IUnknown_AddRef_Proxy,
    IUnknown_Release_Proxy ,
    (void *) (INT_PTR) -1 /* __x_ABI_CPhoneVoIPApp_CBackEnd_CICameraLocationChangedEventHandler::Invoke */
};

const CInterfaceStubVtbl ___x_ABI_CPhoneVoIPApp_CBackEnd_CICameraLocationChangedEventHandlerStubVtbl =
{
    &IID___x_ABI_CPhoneVoIPApp_CBackEnd_CICameraLocationChangedEventHandler,
    &__x_ABI_CPhoneVoIPApp_CBackEnd_CICameraLocationChangedEventHandler_ServerInfo,
    4,
    0, /* pure interpreted */
    CStdStubBuffer_METHODS
};


/* Object interface: __x_ABI_CPhoneVoIPApp_CBackEnd_CIIncomingCallDialogDismissedCallback, ver. 0.0,
   GUID={0x91DDEE70,0xAA90,0x38E7,{0xB4,0xE5,0xF7,0x95,0x95,0x69,0xCB,0x5C}} */

#pragma code_seg(".orpc")
static const unsigned short __x_ABI_CPhoneVoIPApp_CBackEnd_CIIncomingCallDialogDismissedCallback_FormatStringOffsetTable[] =
    {
    84
    };

static const MIDL_STUBLESS_PROXY_INFO __x_ABI_CPhoneVoIPApp_CBackEnd_CIIncomingCallDialogDismissedCallback_ProxyInfo =
    {
    &Object_StubDesc,
    PhoneVoIPApp2EBackEnd__MIDL_ProcFormatString.Format,
    &__x_ABI_CPhoneVoIPApp_CBackEnd_CIIncomingCallDialogDismissedCallback_FormatStringOffsetTable[-3],
    0,
    0,
    0
    };


static const MIDL_SERVER_INFO __x_ABI_CPhoneVoIPApp_CBackEnd_CIIncomingCallDialogDismissedCallback_ServerInfo = 
    {
    &Object_StubDesc,
    0,
    PhoneVoIPApp2EBackEnd__MIDL_ProcFormatString.Format,
    &__x_ABI_CPhoneVoIPApp_CBackEnd_CIIncomingCallDialogDismissedCallback_FormatStringOffsetTable[-3],
    0,
    0,
    0,
    0};
CINTERFACE_PROXY_VTABLE(4) ___x_ABI_CPhoneVoIPApp_CBackEnd_CIIncomingCallDialogDismissedCallbackProxyVtbl = 
{
    &__x_ABI_CPhoneVoIPApp_CBackEnd_CIIncomingCallDialogDismissedCallback_ProxyInfo,
    &IID___x_ABI_CPhoneVoIPApp_CBackEnd_CIIncomingCallDialogDismissedCallback,
    IUnknown_QueryInterface_Proxy,
    IUnknown_AddRef_Proxy,
    IUnknown_Release_Proxy ,
    (void *) (INT_PTR) -1 /* __x_ABI_CPhoneVoIPApp_CBackEnd_CIIncomingCallDialogDismissedCallback::Invoke */
};

const CInterfaceStubVtbl ___x_ABI_CPhoneVoIPApp_CBackEnd_CIIncomingCallDialogDismissedCallbackStubVtbl =
{
    &IID___x_ABI_CPhoneVoIPApp_CBackEnd_CIIncomingCallDialogDismissedCallback,
    &__x_ABI_CPhoneVoIPApp_CBackEnd_CIIncomingCallDialogDismissedCallback_ServerInfo,
    4,
    0, /* pure interpreted */
    CStdStubBuffer_METHODS
};


/* Standard interface: __MIDL_itf_PhoneVoIPApp2EBackEnd_0000_0003, ver. 0.0,
   GUID={0x00000000,0x0000,0x0000,{0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00}} */


/* Object interface: IInspectable, ver. 0.0,
   GUID={0xAF86E2E0,0xB12D,0x4c6a,{0x9C,0x5A,0xD7,0xAA,0x65,0x10,0x1E,0x90}} */


/* Object interface: __x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndTransportPublicNonVirtuals, ver. 0.0,
   GUID={0xF5A3C2AE,0xEF7B,0x3DE2,{0x8B,0x0E,0x8E,0x8B,0x3C,0xD2,0x0D,0x9D}} */

#pragma code_seg(".orpc")
static const unsigned short __x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndTransportPublicNonVirtuals_FormatStringOffsetTable[] =
    {
    (unsigned short) -1,
    (unsigned short) -1,
    (unsigned short) -1,
    114,
    156,
    210,
    252,
    288,
    330
    };

static const MIDL_STUBLESS_PROXY_INFO __x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndTransportPublicNonVirtuals_ProxyInfo =
    {
    &Object_StubDesc,
    PhoneVoIPApp2EBackEnd__MIDL_ProcFormatString.Format,
    &__x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndTransportPublicNonVirtuals_FormatStringOffsetTable[-3],
    0,
    0,
    0
    };


static const MIDL_SERVER_INFO __x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndTransportPublicNonVirtuals_ServerInfo = 
    {
    &Object_StubDesc,
    0,
    PhoneVoIPApp2EBackEnd__MIDL_ProcFormatString.Format,
    &__x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndTransportPublicNonVirtuals_FormatStringOffsetTable[-3],
    0,
    0,
    0,
    0};
CINTERFACE_PROXY_VTABLE(12) ___x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndTransportPublicNonVirtualsProxyVtbl = 
{
    &__x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndTransportPublicNonVirtuals_ProxyInfo,
    &IID___x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndTransportPublicNonVirtuals,
    IUnknown_QueryInterface_Proxy,
    IUnknown_AddRef_Proxy,
    IUnknown_Release_Proxy ,
    0 /* IInspectable::GetIids */ ,
    0 /* IInspectable::GetRuntimeClassName */ ,
    0 /* IInspectable::GetTrustLevel */ ,
    (void *) (INT_PTR) -1 /* __x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndTransportPublicNonVirtuals::WriteAudio */ ,
    (void *) (INT_PTR) -1 /* __x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndTransportPublicNonVirtuals::WriteVideo */ ,
    (void *) (INT_PTR) -1 /* __x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndTransportPublicNonVirtuals::add_AudioMessageReceived */ ,
    (void *) (INT_PTR) -1 /* __x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndTransportPublicNonVirtuals::remove_AudioMessageReceived */ ,
    (void *) (INT_PTR) -1 /* __x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndTransportPublicNonVirtuals::add_VideoMessageReceived */ ,
    (void *) (INT_PTR) -1 /* __x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndTransportPublicNonVirtuals::remove_VideoMessageReceived */
};


static const PRPC_STUB_FUNCTION __x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndTransportPublicNonVirtuals_table[] =
{
    STUB_FORWARDING_FUNCTION,
    STUB_FORWARDING_FUNCTION,
    STUB_FORWARDING_FUNCTION,
    NdrStubCall2,
    NdrStubCall2,
    NdrStubCall2,
    NdrStubCall2,
    NdrStubCall2,
    NdrStubCall2
};

CInterfaceStubVtbl ___x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndTransportPublicNonVirtualsStubVtbl =
{
    &IID___x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndTransportPublicNonVirtuals,
    &__x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndTransportPublicNonVirtuals_ServerInfo,
    12,
    &__x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndTransportPublicNonVirtuals_table[-3],
    CStdStubBuffer_DELEGATING_METHODS
};


/* Standard interface: __MIDL_itf_PhoneVoIPApp2EBackEnd_0000_0004, ver. 0.0,
   GUID={0x00000000,0x0000,0x0000,{0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00}} */


/* Object interface: __x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndTransportProtectedNonVirtuals, ver. 0.0,
   GUID={0x044DEA28,0x0E8D,0x3A16,{0xA2,0xC1,0xBE,0x95,0xC0,0xBE,0xD5,0xE5}} */

#pragma code_seg(".orpc")
static const unsigned short __x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndTransportProtectedNonVirtuals_FormatStringOffsetTable[] =
    {
    (unsigned short) -1,
    (unsigned short) -1,
    (unsigned short) -1,
    0
    };

static const MIDL_STUBLESS_PROXY_INFO __x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndTransportProtectedNonVirtuals_ProxyInfo =
    {
    &Object_StubDesc,
    PhoneVoIPApp2EBackEnd__MIDL_ProcFormatString.Format,
    &__x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndTransportProtectedNonVirtuals_FormatStringOffsetTable[-3],
    0,
    0,
    0
    };


static const MIDL_SERVER_INFO __x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndTransportProtectedNonVirtuals_ServerInfo = 
    {
    &Object_StubDesc,
    0,
    PhoneVoIPApp2EBackEnd__MIDL_ProcFormatString.Format,
    &__x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndTransportProtectedNonVirtuals_FormatStringOffsetTable[-3],
    0,
    0,
    0,
    0};
CINTERFACE_PROXY_VTABLE(6) ___x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndTransportProtectedNonVirtualsProxyVtbl = 
{
    0,
    &IID___x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndTransportProtectedNonVirtuals,
    IUnknown_QueryInterface_Proxy,
    IUnknown_AddRef_Proxy,
    IUnknown_Release_Proxy ,
    0 /* IInspectable::GetIids */ ,
    0 /* IInspectable::GetRuntimeClassName */ ,
    0 /* IInspectable::GetTrustLevel */
};


static const PRPC_STUB_FUNCTION __x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndTransportProtectedNonVirtuals_table[] =
{
    STUB_FORWARDING_FUNCTION,
    STUB_FORWARDING_FUNCTION,
    STUB_FORWARDING_FUNCTION
};

CInterfaceStubVtbl ___x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndTransportProtectedNonVirtualsStubVtbl =
{
    &IID___x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndTransportProtectedNonVirtuals,
    &__x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndTransportProtectedNonVirtuals_ServerInfo,
    6,
    &__x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndTransportProtectedNonVirtuals_table[-3],
    CStdStubBuffer_DELEGATING_METHODS
};


/* Standard interface: __MIDL_itf_PhoneVoIPApp2EBackEnd_0000_0005, ver. 0.0,
   GUID={0x00000000,0x0000,0x0000,{0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00}} */


/* Object interface: __x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndAudioPublicNonVirtuals, ver. 0.0,
   GUID={0xDE465431,0xED24,0x3298,{0xA1,0x87,0x8F,0x1A,0xFB,0xBB,0xE1,0x35}} */

#pragma code_seg(".orpc")
static const unsigned short __x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndAudioPublicNonVirtuals_FormatStringOffsetTable[] =
    {
    (unsigned short) -1,
    (unsigned short) -1,
    (unsigned short) -1,
    366,
    402,
    432
    };

static const MIDL_STUBLESS_PROXY_INFO __x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndAudioPublicNonVirtuals_ProxyInfo =
    {
    &Object_StubDesc,
    PhoneVoIPApp2EBackEnd__MIDL_ProcFormatString.Format,
    &__x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndAudioPublicNonVirtuals_FormatStringOffsetTable[-3],
    0,
    0,
    0
    };


static const MIDL_SERVER_INFO __x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndAudioPublicNonVirtuals_ServerInfo = 
    {
    &Object_StubDesc,
    0,
    PhoneVoIPApp2EBackEnd__MIDL_ProcFormatString.Format,
    &__x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndAudioPublicNonVirtuals_FormatStringOffsetTable[-3],
    0,
    0,
    0,
    0};
CINTERFACE_PROXY_VTABLE(9) ___x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndAudioPublicNonVirtualsProxyVtbl = 
{
    &__x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndAudioPublicNonVirtuals_ProxyInfo,
    &IID___x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndAudioPublicNonVirtuals,
    IUnknown_QueryInterface_Proxy,
    IUnknown_AddRef_Proxy,
    IUnknown_Release_Proxy ,
    0 /* IInspectable::GetIids */ ,
    0 /* IInspectable::GetRuntimeClassName */ ,
    0 /* IInspectable::GetTrustLevel */ ,
    (void *) (INT_PTR) -1 /* __x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndAudioPublicNonVirtuals::SetTransport */ ,
    (void *) (INT_PTR) -1 /* __x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndAudioPublicNonVirtuals::Start */ ,
    (void *) (INT_PTR) -1 /* __x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndAudioPublicNonVirtuals::Stop */
};


static const PRPC_STUB_FUNCTION __x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndAudioPublicNonVirtuals_table[] =
{
    STUB_FORWARDING_FUNCTION,
    STUB_FORWARDING_FUNCTION,
    STUB_FORWARDING_FUNCTION,
    NdrStubCall2,
    NdrStubCall2,
    NdrStubCall2
};

CInterfaceStubVtbl ___x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndAudioPublicNonVirtualsStubVtbl =
{
    &IID___x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndAudioPublicNonVirtuals,
    &__x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndAudioPublicNonVirtuals_ServerInfo,
    9,
    &__x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndAudioPublicNonVirtuals_table[-3],
    CStdStubBuffer_DELEGATING_METHODS
};


/* Standard interface: __MIDL_itf_PhoneVoIPApp2EBackEnd_0000_0006, ver. 0.0,
   GUID={0x00000000,0x0000,0x0000,{0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00}} */


/* Object interface: __x_ABI_CPhoneVoIPApp_CBackEnd_CICallControllerStatusListener, ver. 0.0,
   GUID={0x39126060,0x0292,0x36D6,{0xB3,0xF8,0x9A,0xC4,0x15,0x6C,0x65,0x1D}} */

#pragma code_seg(".orpc")
static const unsigned short __x_ABI_CPhoneVoIPApp_CBackEnd_CICallControllerStatusListener_FormatStringOffsetTable[] =
    {
    (unsigned short) -1,
    (unsigned short) -1,
    (unsigned short) -1,
    462,
    498,
    534,
    570
    };

static const MIDL_STUBLESS_PROXY_INFO __x_ABI_CPhoneVoIPApp_CBackEnd_CICallControllerStatusListener_ProxyInfo =
    {
    &Object_StubDesc,
    PhoneVoIPApp2EBackEnd__MIDL_ProcFormatString.Format,
    &__x_ABI_CPhoneVoIPApp_CBackEnd_CICallControllerStatusListener_FormatStringOffsetTable[-3],
    0,
    0,
    0
    };


static const MIDL_SERVER_INFO __x_ABI_CPhoneVoIPApp_CBackEnd_CICallControllerStatusListener_ServerInfo = 
    {
    &Object_StubDesc,
    0,
    PhoneVoIPApp2EBackEnd__MIDL_ProcFormatString.Format,
    &__x_ABI_CPhoneVoIPApp_CBackEnd_CICallControllerStatusListener_FormatStringOffsetTable[-3],
    0,
    0,
    0,
    0};
CINTERFACE_PROXY_VTABLE(10) ___x_ABI_CPhoneVoIPApp_CBackEnd_CICallControllerStatusListenerProxyVtbl = 
{
    &__x_ABI_CPhoneVoIPApp_CBackEnd_CICallControllerStatusListener_ProxyInfo,
    &IID___x_ABI_CPhoneVoIPApp_CBackEnd_CICallControllerStatusListener,
    IUnknown_QueryInterface_Proxy,
    IUnknown_AddRef_Proxy,
    IUnknown_Release_Proxy ,
    0 /* IInspectable::GetIids */ ,
    0 /* IInspectable::GetRuntimeClassName */ ,
    0 /* IInspectable::GetTrustLevel */ ,
    (void *) (INT_PTR) -1 /* __x_ABI_CPhoneVoIPApp_CBackEnd_CICallControllerStatusListener::OnCallStatusChanged */ ,
    (void *) (INT_PTR) -1 /* __x_ABI_CPhoneVoIPApp_CBackEnd_CICallControllerStatusListener::OnCallAudioRouteChanged */ ,
    (void *) (INT_PTR) -1 /* __x_ABI_CPhoneVoIPApp_CBackEnd_CICallControllerStatusListener::OnMediaOperationsChanged */ ,
    (void *) (INT_PTR) -1 /* __x_ABI_CPhoneVoIPApp_CBackEnd_CICallControllerStatusListener::OnCameraLocationChanged */
};


static const PRPC_STUB_FUNCTION __x_ABI_CPhoneVoIPApp_CBackEnd_CICallControllerStatusListener_table[] =
{
    STUB_FORWARDING_FUNCTION,
    STUB_FORWARDING_FUNCTION,
    STUB_FORWARDING_FUNCTION,
    NdrStubCall2,
    NdrStubCall2,
    NdrStubCall2,
    NdrStubCall2
};

CInterfaceStubVtbl ___x_ABI_CPhoneVoIPApp_CBackEnd_CICallControllerStatusListenerStubVtbl =
{
    &IID___x_ABI_CPhoneVoIPApp_CBackEnd_CICallControllerStatusListener,
    &__x_ABI_CPhoneVoIPApp_CBackEnd_CICallControllerStatusListener_ServerInfo,
    10,
    &__x_ABI_CPhoneVoIPApp_CBackEnd_CICallControllerStatusListener_table[-3],
    CStdStubBuffer_DELEGATING_METHODS
};


/* Standard interface: __MIDL_itf_PhoneVoIPApp2EBackEnd_0000_0007, ver. 0.0,
   GUID={0x00000000,0x0000,0x0000,{0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00}} */


/* Object interface: __x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndCapturePublicNonVirtuals, ver. 0.0,
   GUID={0x8313DBEA,0xFD3B,0x3071,{0x80,0x35,0x7B,0x61,0x16,0x58,0xDA,0xD8}} */

#pragma code_seg(".orpc")
static const unsigned short __x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndCapturePublicNonVirtuals_FormatStringOffsetTable[] =
    {
    (unsigned short) -1,
    (unsigned short) -1,
    (unsigned short) -1,
    366,
    498,
    432,
    606,
    636,
    330
    };

static const MIDL_STUBLESS_PROXY_INFO __x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndCapturePublicNonVirtuals_ProxyInfo =
    {
    &Object_StubDesc,
    PhoneVoIPApp2EBackEnd__MIDL_ProcFormatString.Format,
    &__x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndCapturePublicNonVirtuals_FormatStringOffsetTable[-3],
    0,
    0,
    0
    };


static const MIDL_SERVER_INFO __x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndCapturePublicNonVirtuals_ServerInfo = 
    {
    &Object_StubDesc,
    0,
    PhoneVoIPApp2EBackEnd__MIDL_ProcFormatString.Format,
    &__x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndCapturePublicNonVirtuals_FormatStringOffsetTable[-3],
    0,
    0,
    0,
    0};
CINTERFACE_PROXY_VTABLE(12) ___x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndCapturePublicNonVirtualsProxyVtbl = 
{
    &__x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndCapturePublicNonVirtuals_ProxyInfo,
    &IID___x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndCapturePublicNonVirtuals,
    IUnknown_QueryInterface_Proxy,
    IUnknown_AddRef_Proxy,
    IUnknown_Release_Proxy ,
    0 /* IInspectable::GetIids */ ,
    0 /* IInspectable::GetRuntimeClassName */ ,
    0 /* IInspectable::GetTrustLevel */ ,
    (void *) (INT_PTR) -1 /* __x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndCapturePublicNonVirtuals::SetTransport */ ,
    (void *) (INT_PTR) -1 /* __x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndCapturePublicNonVirtuals::Start */ ,
    (void *) (INT_PTR) -1 /* __x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndCapturePublicNonVirtuals::Stop */ ,
    (void *) (INT_PTR) -1 /* __x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndCapturePublicNonVirtuals::ToggleCamera */ ,
    (void *) (INT_PTR) -1 /* __x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndCapturePublicNonVirtuals::add_CameraLocationChanged */ ,
    (void *) (INT_PTR) -1 /* __x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndCapturePublicNonVirtuals::remove_CameraLocationChanged */
};


static const PRPC_STUB_FUNCTION __x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndCapturePublicNonVirtuals_table[] =
{
    STUB_FORWARDING_FUNCTION,
    STUB_FORWARDING_FUNCTION,
    STUB_FORWARDING_FUNCTION,
    NdrStubCall2,
    NdrStubCall2,
    NdrStubCall2,
    NdrStubCall2,
    NdrStubCall2,
    NdrStubCall2
};

CInterfaceStubVtbl ___x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndCapturePublicNonVirtualsStubVtbl =
{
    &IID___x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndCapturePublicNonVirtuals,
    &__x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndCapturePublicNonVirtuals_ServerInfo,
    12,
    &__x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndCapturePublicNonVirtuals_table[-3],
    CStdStubBuffer_DELEGATING_METHODS
};


/* Standard interface: __MIDL_itf_PhoneVoIPApp2EBackEnd_0000_0008, ver. 0.0,
   GUID={0x00000000,0x0000,0x0000,{0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00}} */


/* Object interface: __x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndCaptureProtectedNonVirtuals, ver. 0.0,
   GUID={0x64B31D5B,0x1A27,0x37A8,{0xBC,0xBC,0xC0,0xBB,0xD5,0x31,0x4C,0x79}} */

#pragma code_seg(".orpc")
static const unsigned short __x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndCaptureProtectedNonVirtuals_FormatStringOffsetTable[] =
    {
    (unsigned short) -1,
    (unsigned short) -1,
    (unsigned short) -1,
    0
    };

static const MIDL_STUBLESS_PROXY_INFO __x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndCaptureProtectedNonVirtuals_ProxyInfo =
    {
    &Object_StubDesc,
    PhoneVoIPApp2EBackEnd__MIDL_ProcFormatString.Format,
    &__x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndCaptureProtectedNonVirtuals_FormatStringOffsetTable[-3],
    0,
    0,
    0
    };


static const MIDL_SERVER_INFO __x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndCaptureProtectedNonVirtuals_ServerInfo = 
    {
    &Object_StubDesc,
    0,
    PhoneVoIPApp2EBackEnd__MIDL_ProcFormatString.Format,
    &__x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndCaptureProtectedNonVirtuals_FormatStringOffsetTable[-3],
    0,
    0,
    0,
    0};
CINTERFACE_PROXY_VTABLE(6) ___x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndCaptureProtectedNonVirtualsProxyVtbl = 
{
    0,
    &IID___x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndCaptureProtectedNonVirtuals,
    IUnknown_QueryInterface_Proxy,
    IUnknown_AddRef_Proxy,
    IUnknown_Release_Proxy ,
    0 /* IInspectable::GetIids */ ,
    0 /* IInspectable::GetRuntimeClassName */ ,
    0 /* IInspectable::GetTrustLevel */
};


static const PRPC_STUB_FUNCTION __x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndCaptureProtectedNonVirtuals_table[] =
{
    STUB_FORWARDING_FUNCTION,
    STUB_FORWARDING_FUNCTION,
    STUB_FORWARDING_FUNCTION
};

CInterfaceStubVtbl ___x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndCaptureProtectedNonVirtualsStubVtbl =
{
    &IID___x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndCaptureProtectedNonVirtuals,
    &__x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndCaptureProtectedNonVirtuals_ServerInfo,
    6,
    &__x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndCaptureProtectedNonVirtuals_table[-3],
    CStdStubBuffer_DELEGATING_METHODS
};


/* Standard interface: __MIDL_itf_PhoneVoIPApp2EBackEnd_0000_0009, ver. 0.0,
   GUID={0x00000000,0x0000,0x0000,{0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00}} */


/* Object interface: __x_ABI_CPhoneVoIPApp_CBackEnd_C____ICallControllerPublicNonVirtuals, ver. 0.0,
   GUID={0x06B50718,0x3528,0x3B66,{0xBE,0x76,0xE1,0x83,0xAA,0x80,0xD4,0xA5}} */

#pragma code_seg(".orpc")
static const unsigned short __x_ABI_CPhoneVoIPApp_CBackEnd_C____ICallControllerPublicNonVirtuals_FormatStringOffsetTable[] =
    {
    (unsigned short) -1,
    (unsigned short) -1,
    (unsigned short) -1,
    678,
    714,
    762,
    816,
    852,
    888,
    924,
    960,
    996,
    1032,
    1068,
    1104,
    1140,
    1176,
    1212,
    1248,
    1284,
    1320,
    1356,
    1392
    };

static const MIDL_STUBLESS_PROXY_INFO __x_ABI_CPhoneVoIPApp_CBackEnd_C____ICallControllerPublicNonVirtuals_ProxyInfo =
    {
    &Object_StubDesc,
    PhoneVoIPApp2EBackEnd__MIDL_ProcFormatString.Format,
    &__x_ABI_CPhoneVoIPApp_CBackEnd_C____ICallControllerPublicNonVirtuals_FormatStringOffsetTable[-3],
    0,
    0,
    0
    };


static const MIDL_SERVER_INFO __x_ABI_CPhoneVoIPApp_CBackEnd_C____ICallControllerPublicNonVirtuals_ServerInfo = 
    {
    &Object_StubDesc,
    0,
    PhoneVoIPApp2EBackEnd__MIDL_ProcFormatString.Format,
    &__x_ABI_CPhoneVoIPApp_CBackEnd_C____ICallControllerPublicNonVirtuals_FormatStringOffsetTable[-3],
    0,
    0,
    0,
    0};
CINTERFACE_PROXY_VTABLE(26) ___x_ABI_CPhoneVoIPApp_CBackEnd_C____ICallControllerPublicNonVirtualsProxyVtbl = 
{
    &__x_ABI_CPhoneVoIPApp_CBackEnd_C____ICallControllerPublicNonVirtuals_ProxyInfo,
    &IID___x_ABI_CPhoneVoIPApp_CBackEnd_C____ICallControllerPublicNonVirtuals,
    IUnknown_QueryInterface_Proxy,
    IUnknown_AddRef_Proxy,
    IUnknown_Release_Proxy ,
    0 /* IInspectable::GetIids */ ,
    0 /* IInspectable::GetRuntimeClassName */ ,
    0 /* IInspectable::GetTrustLevel */ ,
    (void *) (INT_PTR) -1 /* __x_ABI_CPhoneVoIPApp_CBackEnd_C____ICallControllerPublicNonVirtuals::SetStatusCallback */ ,
    (void *) (INT_PTR) -1 /* __x_ABI_CPhoneVoIPApp_CBackEnd_C____ICallControllerPublicNonVirtuals::InitiateOutgoingCall */ ,
    (void *) (INT_PTR) -1 /* __x_ABI_CPhoneVoIPApp_CBackEnd_C____ICallControllerPublicNonVirtuals::OnIncomingCallReceived */ ,
    (void *) (INT_PTR) -1 /* __x_ABI_CPhoneVoIPApp_CBackEnd_C____ICallControllerPublicNonVirtuals::HoldCall */ ,
    (void *) (INT_PTR) -1 /* __x_ABI_CPhoneVoIPApp_CBackEnd_C____ICallControllerPublicNonVirtuals::ResumeCall */ ,
    (void *) (INT_PTR) -1 /* __x_ABI_CPhoneVoIPApp_CBackEnd_C____ICallControllerPublicNonVirtuals::EndCall */ ,
    (void *) (INT_PTR) -1 /* __x_ABI_CPhoneVoIPApp_CBackEnd_C____ICallControllerPublicNonVirtuals::ToggleCamera */ ,
    (void *) (INT_PTR) -1 /* __x_ABI_CPhoneVoIPApp_CBackEnd_C____ICallControllerPublicNonVirtuals::get_CallStatus */ ,
    (void *) (INT_PTR) -1 /* __x_ABI_CPhoneVoIPApp_CBackEnd_C____ICallControllerPublicNonVirtuals::get_MediaOperations */ ,
    (void *) (INT_PTR) -1 /* __x_ABI_CPhoneVoIPApp_CBackEnd_C____ICallControllerPublicNonVirtuals::get_IsShowingVideo */ ,
    (void *) (INT_PTR) -1 /* __x_ABI_CPhoneVoIPApp_CBackEnd_C____ICallControllerPublicNonVirtuals::put_IsShowingVideo */ ,
    (void *) (INT_PTR) -1 /* __x_ABI_CPhoneVoIPApp_CBackEnd_C____ICallControllerPublicNonVirtuals::get_IsRenderingVideo */ ,
    (void *) (INT_PTR) -1 /* __x_ABI_CPhoneVoIPApp_CBackEnd_C____ICallControllerPublicNonVirtuals::put_IsRenderingVideo */ ,
    (void *) (INT_PTR) -1 /* __x_ABI_CPhoneVoIPApp_CBackEnd_C____ICallControllerPublicNonVirtuals::get_CameraLocation */ ,
    (void *) (INT_PTR) -1 /* __x_ABI_CPhoneVoIPApp_CBackEnd_C____ICallControllerPublicNonVirtuals::get_AvailableAudioRoutes */ ,
    (void *) (INT_PTR) -1 /* __x_ABI_CPhoneVoIPApp_CBackEnd_C____ICallControllerPublicNonVirtuals::get_AudioRoute */ ,
    (void *) (INT_PTR) -1 /* __x_ABI_CPhoneVoIPApp_CBackEnd_C____ICallControllerPublicNonVirtuals::put_AudioRoute */ ,
    (void *) (INT_PTR) -1 /* __x_ABI_CPhoneVoIPApp_CBackEnd_C____ICallControllerPublicNonVirtuals::get_OtherPartyName */ ,
    (void *) (INT_PTR) -1 /* __x_ABI_CPhoneVoIPApp_CBackEnd_C____ICallControllerPublicNonVirtuals::get_OtherPartyNumber */ ,
    (void *) (INT_PTR) -1 /* __x_ABI_CPhoneVoIPApp_CBackEnd_C____ICallControllerPublicNonVirtuals::get_CallStartTime */
};


static const PRPC_STUB_FUNCTION __x_ABI_CPhoneVoIPApp_CBackEnd_C____ICallControllerPublicNonVirtuals_table[] =
{
    STUB_FORWARDING_FUNCTION,
    STUB_FORWARDING_FUNCTION,
    STUB_FORWARDING_FUNCTION,
    NdrStubCall2,
    NdrStubCall2,
    NdrStubCall2,
    NdrStubCall2,
    NdrStubCall2,
    NdrStubCall2,
    NdrStubCall2,
    NdrStubCall2,
    NdrStubCall2,
    NdrStubCall2,
    NdrStubCall2,
    NdrStubCall2,
    NdrStubCall2,
    NdrStubCall2,
    NdrStubCall2,
    NdrStubCall2,
    NdrStubCall2,
    NdrStubCall2,
    NdrStubCall2,
    NdrStubCall2
};

CInterfaceStubVtbl ___x_ABI_CPhoneVoIPApp_CBackEnd_C____ICallControllerPublicNonVirtualsStubVtbl =
{
    &IID___x_ABI_CPhoneVoIPApp_CBackEnd_C____ICallControllerPublicNonVirtuals,
    &__x_ABI_CPhoneVoIPApp_CBackEnd_C____ICallControllerPublicNonVirtuals_ServerInfo,
    26,
    &__x_ABI_CPhoneVoIPApp_CBackEnd_C____ICallControllerPublicNonVirtuals_table[-3],
    CStdStubBuffer_DELEGATING_METHODS
};


/* Standard interface: __MIDL_itf_PhoneVoIPApp2EBackEnd_0000_0010, ver. 0.0,
   GUID={0x00000000,0x0000,0x0000,{0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00}} */


/* Object interface: __x_ABI_CPhoneVoIPApp_CBackEnd_CIVideoRenderer, ver. 0.0,
   GUID={0x6928CA7B,0x166D,0x3B37,{0x90,0x10,0xFB,0xAB,0x2C,0x7E,0x92,0xB0}} */

#pragma code_seg(".orpc")
static const unsigned short __x_ABI_CPhoneVoIPApp_CBackEnd_CIVideoRenderer_FormatStringOffsetTable[] =
    {
    (unsigned short) -1,
    (unsigned short) -1,
    (unsigned short) -1,
    1428,
    402
    };

static const MIDL_STUBLESS_PROXY_INFO __x_ABI_CPhoneVoIPApp_CBackEnd_CIVideoRenderer_ProxyInfo =
    {
    &Object_StubDesc,
    PhoneVoIPApp2EBackEnd__MIDL_ProcFormatString.Format,
    &__x_ABI_CPhoneVoIPApp_CBackEnd_CIVideoRenderer_FormatStringOffsetTable[-3],
    0,
    0,
    0
    };


static const MIDL_SERVER_INFO __x_ABI_CPhoneVoIPApp_CBackEnd_CIVideoRenderer_ServerInfo = 
    {
    &Object_StubDesc,
    0,
    PhoneVoIPApp2EBackEnd__MIDL_ProcFormatString.Format,
    &__x_ABI_CPhoneVoIPApp_CBackEnd_CIVideoRenderer_FormatStringOffsetTable[-3],
    0,
    0,
    0,
    0};
CINTERFACE_PROXY_VTABLE(8) ___x_ABI_CPhoneVoIPApp_CBackEnd_CIVideoRendererProxyVtbl = 
{
    &__x_ABI_CPhoneVoIPApp_CBackEnd_CIVideoRenderer_ProxyInfo,
    &IID___x_ABI_CPhoneVoIPApp_CBackEnd_CIVideoRenderer,
    IUnknown_QueryInterface_Proxy,
    IUnknown_AddRef_Proxy,
    IUnknown_Release_Proxy ,
    0 /* IInspectable::GetIids */ ,
    0 /* IInspectable::GetRuntimeClassName */ ,
    0 /* IInspectable::GetTrustLevel */ ,
    (void *) (INT_PTR) -1 /* __x_ABI_CPhoneVoIPApp_CBackEnd_CIVideoRenderer::Start */ ,
    (void *) (INT_PTR) -1 /* __x_ABI_CPhoneVoIPApp_CBackEnd_CIVideoRenderer::Stop */
};


static const PRPC_STUB_FUNCTION __x_ABI_CPhoneVoIPApp_CBackEnd_CIVideoRenderer_table[] =
{
    STUB_FORWARDING_FUNCTION,
    STUB_FORWARDING_FUNCTION,
    STUB_FORWARDING_FUNCTION,
    NdrStubCall2,
    NdrStubCall2
};

CInterfaceStubVtbl ___x_ABI_CPhoneVoIPApp_CBackEnd_CIVideoRendererStubVtbl =
{
    &IID___x_ABI_CPhoneVoIPApp_CBackEnd_CIVideoRenderer,
    &__x_ABI_CPhoneVoIPApp_CBackEnd_CIVideoRenderer_ServerInfo,
    8,
    &__x_ABI_CPhoneVoIPApp_CBackEnd_CIVideoRenderer_table[-3],
    CStdStubBuffer_DELEGATING_METHODS
};


/* Standard interface: __MIDL_itf_PhoneVoIPApp2EBackEnd_0000_0011, ver. 0.0,
   GUID={0x00000000,0x0000,0x0000,{0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00}} */


/* Object interface: __x_ABI_CPhoneVoIPApp_CBackEnd_C____IGlobalsPublicNonVirtuals, ver. 0.0,
   GUID={0xC8AFE1A8,0x92FC,0x3783,{0x95,0x20,0xD6,0xBB,0xC5,0x07,0xB2,0x4A}} */

#pragma code_seg(".orpc")
static const unsigned short __x_ABI_CPhoneVoIPApp_CBackEnd_C____IGlobalsPublicNonVirtuals_FormatStringOffsetTable[] =
    {
    (unsigned short) -1,
    (unsigned short) -1,
    (unsigned short) -1,
    1458,
    402,
    1500,
    1536,
    1572,
    1608,
    1644,
    1680
    };

static const MIDL_STUBLESS_PROXY_INFO __x_ABI_CPhoneVoIPApp_CBackEnd_C____IGlobalsPublicNonVirtuals_ProxyInfo =
    {
    &Object_StubDesc,
    PhoneVoIPApp2EBackEnd__MIDL_ProcFormatString.Format,
    &__x_ABI_CPhoneVoIPApp_CBackEnd_C____IGlobalsPublicNonVirtuals_FormatStringOffsetTable[-3],
    0,
    0,
    0
    };


static const MIDL_SERVER_INFO __x_ABI_CPhoneVoIPApp_CBackEnd_C____IGlobalsPublicNonVirtuals_ServerInfo = 
    {
    &Object_StubDesc,
    0,
    PhoneVoIPApp2EBackEnd__MIDL_ProcFormatString.Format,
    &__x_ABI_CPhoneVoIPApp_CBackEnd_C____IGlobalsPublicNonVirtuals_FormatStringOffsetTable[-3],
    0,
    0,
    0,
    0};
CINTERFACE_PROXY_VTABLE(14) ___x_ABI_CPhoneVoIPApp_CBackEnd_C____IGlobalsPublicNonVirtualsProxyVtbl = 
{
    &__x_ABI_CPhoneVoIPApp_CBackEnd_C____IGlobalsPublicNonVirtuals_ProxyInfo,
    &IID___x_ABI_CPhoneVoIPApp_CBackEnd_C____IGlobalsPublicNonVirtuals,
    IUnknown_QueryInterface_Proxy,
    IUnknown_AddRef_Proxy,
    IUnknown_Release_Proxy ,
    0 /* IInspectable::GetIids */ ,
    0 /* IInspectable::GetRuntimeClassName */ ,
    0 /* IInspectable::GetTrustLevel */ ,
    (void *) (INT_PTR) -1 /* __x_ABI_CPhoneVoIPApp_CBackEnd_C____IGlobalsPublicNonVirtuals::StartServer */ ,
    (void *) (INT_PTR) -1 /* __x_ABI_CPhoneVoIPApp_CBackEnd_C____IGlobalsPublicNonVirtuals::DoPeriodicKeepAlive */ ,
    (void *) (INT_PTR) -1 /* __x_ABI_CPhoneVoIPApp_CBackEnd_C____IGlobalsPublicNonVirtuals::get_CallController */ ,
    (void *) (INT_PTR) -1 /* __x_ABI_CPhoneVoIPApp_CBackEnd_C____IGlobalsPublicNonVirtuals::get_VideoRenderer */ ,
    (void *) (INT_PTR) -1 /* __x_ABI_CPhoneVoIPApp_CBackEnd_C____IGlobalsPublicNonVirtuals::put_VideoRenderer */ ,
    (void *) (INT_PTR) -1 /* __x_ABI_CPhoneVoIPApp_CBackEnd_C____IGlobalsPublicNonVirtuals::get_AudioController */ ,
    (void *) (INT_PTR) -1 /* __x_ABI_CPhoneVoIPApp_CBackEnd_C____IGlobalsPublicNonVirtuals::get_CaptureController */ ,
    (void *) (INT_PTR) -1 /* __x_ABI_CPhoneVoIPApp_CBackEnd_C____IGlobalsPublicNonVirtuals::get_TransportController */
};


static const PRPC_STUB_FUNCTION __x_ABI_CPhoneVoIPApp_CBackEnd_C____IGlobalsPublicNonVirtuals_table[] =
{
    STUB_FORWARDING_FUNCTION,
    STUB_FORWARDING_FUNCTION,
    STUB_FORWARDING_FUNCTION,
    NdrStubCall2,
    NdrStubCall2,
    NdrStubCall2,
    NdrStubCall2,
    NdrStubCall2,
    NdrStubCall2,
    NdrStubCall2,
    NdrStubCall2
};

CInterfaceStubVtbl ___x_ABI_CPhoneVoIPApp_CBackEnd_C____IGlobalsPublicNonVirtualsStubVtbl =
{
    &IID___x_ABI_CPhoneVoIPApp_CBackEnd_C____IGlobalsPublicNonVirtuals,
    &__x_ABI_CPhoneVoIPApp_CBackEnd_C____IGlobalsPublicNonVirtuals_ServerInfo,
    14,
    &__x_ABI_CPhoneVoIPApp_CBackEnd_C____IGlobalsPublicNonVirtuals_table[-3],
    CStdStubBuffer_DELEGATING_METHODS
};


/* Standard interface: __MIDL_itf_PhoneVoIPApp2EBackEnd_0000_0012, ver. 0.0,
   GUID={0x00000000,0x0000,0x0000,{0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00}} */


/* Object interface: __x_ABI_CPhoneVoIPApp_CBackEnd_C____IGlobalsStatics, ver. 0.0,
   GUID={0x2C1E9C37,0x6827,0x38F7,{0x85,0x7C,0x02,0x16,0x42,0xCA,0x42,0x8B}} */

#pragma code_seg(".orpc")
static const unsigned short __x_ABI_CPhoneVoIPApp_CBackEnd_C____IGlobalsStatics_FormatStringOffsetTable[] =
    {
    (unsigned short) -1,
    (unsigned short) -1,
    (unsigned short) -1,
    1716,
    1752,
    1794,
    1836
    };

static const MIDL_STUBLESS_PROXY_INFO __x_ABI_CPhoneVoIPApp_CBackEnd_C____IGlobalsStatics_ProxyInfo =
    {
    &Object_StubDesc,
    PhoneVoIPApp2EBackEnd__MIDL_ProcFormatString.Format,
    &__x_ABI_CPhoneVoIPApp_CBackEnd_C____IGlobalsStatics_FormatStringOffsetTable[-3],
    0,
    0,
    0
    };


static const MIDL_SERVER_INFO __x_ABI_CPhoneVoIPApp_CBackEnd_C____IGlobalsStatics_ServerInfo = 
    {
    &Object_StubDesc,
    0,
    PhoneVoIPApp2EBackEnd__MIDL_ProcFormatString.Format,
    &__x_ABI_CPhoneVoIPApp_CBackEnd_C____IGlobalsStatics_FormatStringOffsetTable[-3],
    0,
    0,
    0,
    0};
CINTERFACE_PROXY_VTABLE(10) ___x_ABI_CPhoneVoIPApp_CBackEnd_C____IGlobalsStaticsProxyVtbl = 
{
    &__x_ABI_CPhoneVoIPApp_CBackEnd_C____IGlobalsStatics_ProxyInfo,
    &IID___x_ABI_CPhoneVoIPApp_CBackEnd_C____IGlobalsStatics,
    IUnknown_QueryInterface_Proxy,
    IUnknown_AddRef_Proxy,
    IUnknown_Release_Proxy ,
    0 /* IInspectable::GetIids */ ,
    0 /* IInspectable::GetRuntimeClassName */ ,
    0 /* IInspectable::GetTrustLevel */ ,
    (void *) (INT_PTR) -1 /* __x_ABI_CPhoneVoIPApp_CBackEnd_C____IGlobalsStatics::GetCurrentProcessId */ ,
    (void *) (INT_PTR) -1 /* __x_ABI_CPhoneVoIPApp_CBackEnd_C____IGlobalsStatics::GetUiDisconnectedEventName */ ,
    (void *) (INT_PTR) -1 /* __x_ABI_CPhoneVoIPApp_CBackEnd_C____IGlobalsStatics::GetBackgroundProcessReadyEventName */ ,
    (void *) (INT_PTR) -1 /* __x_ABI_CPhoneVoIPApp_CBackEnd_C____IGlobalsStatics::get_Instance */
};


static const PRPC_STUB_FUNCTION __x_ABI_CPhoneVoIPApp_CBackEnd_C____IGlobalsStatics_table[] =
{
    STUB_FORWARDING_FUNCTION,
    STUB_FORWARDING_FUNCTION,
    STUB_FORWARDING_FUNCTION,
    NdrStubCall2,
    NdrStubCall2,
    NdrStubCall2,
    NdrStubCall2
};

CInterfaceStubVtbl ___x_ABI_CPhoneVoIPApp_CBackEnd_C____IGlobalsStaticsStubVtbl =
{
    &IID___x_ABI_CPhoneVoIPApp_CBackEnd_C____IGlobalsStatics,
    &__x_ABI_CPhoneVoIPApp_CBackEnd_C____IGlobalsStatics_ServerInfo,
    10,
    &__x_ABI_CPhoneVoIPApp_CBackEnd_C____IGlobalsStatics_table[-3],
    CStdStubBuffer_DELEGATING_METHODS
};


/* Standard interface: __MIDL_itf_PhoneVoIPApp2EBackEnd_0000_0013, ver. 0.0,
   GUID={0x00000000,0x0000,0x0000,{0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00}} */

static const MIDL_STUB_DESC Object_StubDesc = 
    {
    0,
    NdrOleAllocate,
    NdrOleFree,
    0,
    0,
    0,
    0,
    0,
    PhoneVoIPApp2EBackEnd__MIDL_TypeFormatString.Format,
    1, /* -error bounds_check flag */
    0x50002, /* Ndr library version */
    0,
    0x8000253, /* MIDL Version 8.0.595 */
    0,
    UserMarshalRoutines,
    0,  /* notify & notify_flag routine table */
    0x1, /* MIDL flag */
    0, /* cs routines */
    0,   /* proxy/server info */
    0
    };

const CInterfaceProxyVtbl * const _PhoneVoIPApp2EBackEnd_ProxyVtblList[] = 
{
    ( CInterfaceProxyVtbl *) &___x_ABI_CPhoneVoIPApp_CBackEnd_C____ICallControllerPublicNonVirtualsProxyVtbl,
    ( CInterfaceProxyVtbl *) &___x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndTransportProtectedNonVirtualsProxyVtbl,
    ( CInterfaceProxyVtbl *) &___x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndAudioPublicNonVirtualsProxyVtbl,
    ( CInterfaceProxyVtbl *) &___x_ABI_CPhoneVoIPApp_CBackEnd_C____IGlobalsStaticsProxyVtbl,
    ( CInterfaceProxyVtbl *) &___x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndCaptureProtectedNonVirtualsProxyVtbl,
    ( CInterfaceProxyVtbl *) &___x_ABI_CPhoneVoIPApp_CBackEnd_CICallControllerStatusListenerProxyVtbl,
    ( CInterfaceProxyVtbl *) &___x_ABI_CPhoneVoIPApp_CBackEnd_CICameraLocationChangedEventHandlerProxyVtbl,
    ( CInterfaceProxyVtbl *) &___x_ABI_CPhoneVoIPApp_CBackEnd_CIMessageReceivedEventHandlerProxyVtbl,
    ( CInterfaceProxyVtbl *) &___x_ABI_CPhoneVoIPApp_CBackEnd_CIIncomingCallDialogDismissedCallbackProxyVtbl,
    ( CInterfaceProxyVtbl *) &___x_ABI_CPhoneVoIPApp_CBackEnd_CIVideoRendererProxyVtbl,
    ( CInterfaceProxyVtbl *) &___x_ABI_CPhoneVoIPApp_CBackEnd_C____IGlobalsPublicNonVirtualsProxyVtbl,
    ( CInterfaceProxyVtbl *) &___x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndTransportPublicNonVirtualsProxyVtbl,
    ( CInterfaceProxyVtbl *) &___x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndCapturePublicNonVirtualsProxyVtbl,
    0
};

const CInterfaceStubVtbl * const _PhoneVoIPApp2EBackEnd_StubVtblList[] = 
{
    ( CInterfaceStubVtbl *) &___x_ABI_CPhoneVoIPApp_CBackEnd_C____ICallControllerPublicNonVirtualsStubVtbl,
    ( CInterfaceStubVtbl *) &___x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndTransportProtectedNonVirtualsStubVtbl,
    ( CInterfaceStubVtbl *) &___x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndAudioPublicNonVirtualsStubVtbl,
    ( CInterfaceStubVtbl *) &___x_ABI_CPhoneVoIPApp_CBackEnd_C____IGlobalsStaticsStubVtbl,
    ( CInterfaceStubVtbl *) &___x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndCaptureProtectedNonVirtualsStubVtbl,
    ( CInterfaceStubVtbl *) &___x_ABI_CPhoneVoIPApp_CBackEnd_CICallControllerStatusListenerStubVtbl,
    ( CInterfaceStubVtbl *) &___x_ABI_CPhoneVoIPApp_CBackEnd_CICameraLocationChangedEventHandlerStubVtbl,
    ( CInterfaceStubVtbl *) &___x_ABI_CPhoneVoIPApp_CBackEnd_CIMessageReceivedEventHandlerStubVtbl,
    ( CInterfaceStubVtbl *) &___x_ABI_CPhoneVoIPApp_CBackEnd_CIIncomingCallDialogDismissedCallbackStubVtbl,
    ( CInterfaceStubVtbl *) &___x_ABI_CPhoneVoIPApp_CBackEnd_CIVideoRendererStubVtbl,
    ( CInterfaceStubVtbl *) &___x_ABI_CPhoneVoIPApp_CBackEnd_C____IGlobalsPublicNonVirtualsStubVtbl,
    ( CInterfaceStubVtbl *) &___x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndTransportPublicNonVirtualsStubVtbl,
    ( CInterfaceStubVtbl *) &___x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndCapturePublicNonVirtualsStubVtbl,
    0
};

PCInterfaceName const _PhoneVoIPApp2EBackEnd_InterfaceNamesList[] = 
{
    "__x_ABI_CPhoneVoIPApp_CBackEnd_C____ICallControllerPublicNonVirtuals",
    "__x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndTransportProtectedNonVirtuals",
    "__x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndAudioPublicNonVirtuals",
    "__x_ABI_CPhoneVoIPApp_CBackEnd_C____IGlobalsStatics",
    "__x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndCaptureProtectedNonVirtuals",
    "__x_ABI_CPhoneVoIPApp_CBackEnd_CICallControllerStatusListener",
    "__x_ABI_CPhoneVoIPApp_CBackEnd_CICameraLocationChangedEventHandler",
    "__x_ABI_CPhoneVoIPApp_CBackEnd_CIMessageReceivedEventHandler",
    "__x_ABI_CPhoneVoIPApp_CBackEnd_CIIncomingCallDialogDismissedCallback",
    "__x_ABI_CPhoneVoIPApp_CBackEnd_CIVideoRenderer",
    "__x_ABI_CPhoneVoIPApp_CBackEnd_C____IGlobalsPublicNonVirtuals",
    "__x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndTransportPublicNonVirtuals",
    "__x_ABI_CPhoneVoIPApp_CBackEnd_C____IBackEndCapturePublicNonVirtuals",
    0
};

const IID *  const _PhoneVoIPApp2EBackEnd_BaseIIDList[] = 
{
    &IID_IInspectable,
    &IID_IInspectable,
    &IID_IInspectable,
    &IID_IInspectable,
    &IID_IInspectable,
    &IID_IInspectable,
    0,
    0,
    0,
    &IID_IInspectable,
    &IID_IInspectable,
    &IID_IInspectable,
    &IID_IInspectable,
    0
};


#define _PhoneVoIPApp2EBackEnd_CHECK_IID(n)	IID_GENERIC_CHECK_IID( _PhoneVoIPApp2EBackEnd, pIID, n)

int __stdcall _PhoneVoIPApp2EBackEnd_IID_Lookup( const IID * pIID, int * pIndex )
{
    IID_BS_LOOKUP_SETUP

    IID_BS_LOOKUP_INITIAL_TEST( _PhoneVoIPApp2EBackEnd, 13, 8 )
    IID_BS_LOOKUP_NEXT_TEST( _PhoneVoIPApp2EBackEnd, 4 )
    IID_BS_LOOKUP_NEXT_TEST( _PhoneVoIPApp2EBackEnd, 2 )
    IID_BS_LOOKUP_NEXT_TEST( _PhoneVoIPApp2EBackEnd, 1 )
    IID_BS_LOOKUP_RETURN_RESULT( _PhoneVoIPApp2EBackEnd, 13, *pIndex )
    
}

const ExtendedProxyFileInfo PhoneVoIPApp2EBackEnd_ProxyFileInfo = 
{
    (PCInterfaceProxyVtblList *) & _PhoneVoIPApp2EBackEnd_ProxyVtblList,
    (PCInterfaceStubVtblList *) & _PhoneVoIPApp2EBackEnd_StubVtblList,
    (const PCInterfaceName * ) & _PhoneVoIPApp2EBackEnd_InterfaceNamesList,
    (const IID ** ) & _PhoneVoIPApp2EBackEnd_BaseIIDList,
    & _PhoneVoIPApp2EBackEnd_IID_Lookup, 
    13,
    2,
    0, /* table of [async_uuid] interfaces */
    0, /* Filler1 */
    0, /* Filler2 */
    0  /* Filler3 */
};
#pragma optimize("", on )
#if _MSC_VER >= 1200
#pragma warning(pop)
#endif


#endif /* !defined(_M_IA64) && !defined(_M_AMD64) && !defined(_ARM_) */

