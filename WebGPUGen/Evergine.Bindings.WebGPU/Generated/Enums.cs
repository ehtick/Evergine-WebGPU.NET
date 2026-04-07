using System;

namespace Evergine.Bindings.WebGPU
{
	public enum WGPUWGSLFeatureName
	{
		Undefined = 0,
		ReadonlyAndReadwriteStorageTextures = 1,
		Packed4x8IntegerDotProduct = 2,
		UnrestrictedPointerParameters = 3,
		PointerCompositeAccess = 4,
		Force32 = 2147483647,
	}

	public enum WGPUAdapterType
	{
		DiscreteGPU = 1,
		IntegratedGPU = 2,
		CPU = 3,
		Unknown = 4,
		Force32 = 2147483647,
	}

	public enum WGPUAddressMode
	{
		Undefined = 0,
		ClampToEdge = 1,
		Repeat = 2,
		MirrorRepeat = 3,
		Force32 = 2147483647,
	}

	public enum WGPUBackendType
	{
		Undefined = 0,
		Null = 1,
		WebGPU = 2,
		D3D11 = 3,
		D3D12 = 4,
		Metal = 5,
		Vulkan = 6,
		OpenGL = 7,
		OpenGLES = 8,
		Force32 = 2147483647,
	}

	public enum WGPUBlendFactor
	{
		Undefined = 0,
		Zero = 1,
		One = 2,
		Src = 3,
		OneMinusSrc = 4,
		SrcAlpha = 5,
		OneMinusSrcAlpha = 6,
		Dst = 7,
		OneMinusDst = 8,
		DstAlpha = 9,
		OneMinusDstAlpha = 10,
		SrcAlphaSaturated = 11,
		Constant = 12,
		OneMinusConstant = 13,
		Force32 = 2147483647,
	}

	public enum WGPUBlendOperation
	{
		Undefined = 0,
		Add = 1,
		Subtract = 2,
		ReverseSubtract = 3,
		Min = 4,
		Max = 5,
		Force32 = 2147483647,
	}

	public enum WGPUBufferBindingType
	{
		Undefined = 0,
		Uniform = 1,
		Storage = 2,
		ReadOnlyStorage = 3,
		Force32 = 2147483647,
	}

	public enum WGPUBufferMapAsyncStatus
	{
		Success = 0,
		ValidationError = 1,
		Unknown = 2,
		DeviceLost = 3,
		DestroyedBeforeCallback = 4,
		UnmappedBeforeCallback = 5,
		MappingAlreadyPending = 6,
		OffsetOutOfRange = 7,
		SizeOutOfRange = 8,
		Force32 = 2147483647,
	}

	public enum WGPUBufferMapState
	{
		Unmapped = 1,
		Pending = 2,
		Mapped = 3,
		Force32 = 2147483647,
	}

	public enum WGPUCallbackMode
	{
		WaitAnyOnly = 0,
		AllowProcessEvents = 1,
		AllowSpontaneous = 2,
		Force32 = 2147483647,
	}

	public enum WGPUCompareFunction
	{
		Undefined = 0,
		Never = 1,
		Less = 2,
		Equal = 3,
		LessEqual = 4,
		Greater = 5,
		NotEqual = 6,
		GreaterEqual = 7,
		Always = 8,
		Force32 = 2147483647,
	}

	public enum WGPUCompilationInfoRequestStatus
	{
		Success = 0,
		Error = 1,
		DeviceLost = 2,
		Unknown = 3,
		Force32 = 2147483647,
	}

	public enum WGPUCompilationMessageType
	{
		Error = 1,
		Warning = 2,
		Info = 3,
		Force32 = 2147483647,
	}

	public enum WGPUCreatePipelineAsyncStatus
	{
		Success = 0,
		ValidationError = 1,
		InternalError = 2,
		DeviceLost = 3,
		DeviceDestroyed = 4,
		Unknown = 5,
		Force32 = 2147483647,
	}

	public enum WGPUCullMode
	{
		Undefined = 0,
		None = 1,
		Front = 2,
		Back = 3,
		Force32 = 2147483647,
	}

	public enum WGPUDeviceLostReason
	{
		Undefined = 0,
		Destroyed = 1,
		Force32 = 2147483647,
	}

	public enum WGPUErrorFilter
	{
		Validation = 1,
		OutOfMemory = 2,
		Internal = 3,
		Force32 = 2147483647,
	}

	public enum WGPUErrorType
	{
		NoError = 0,
		Validation = 1,
		OutOfMemory = 2,
		Internal = 3,
		Unknown = 4,
		DeviceLost = 5,
		Force32 = 2147483647,
	}

	public enum WGPUFeatureName
	{
		Undefined = 0,
		DepthClipControl = 1,
		Depth32FloatStencil8 = 2,
		TimestampQuery = 3,
		TextureCompressionBC = 4,
		TextureCompressionETC2 = 5,
		TextureCompressionASTC = 6,
		IndirectFirstInstance = 7,
		ShaderF16 = 8,
		RG11B10UfloatRenderable = 9,
		BGRA8UnormStorage = 10,
		Float32Filterable = 11,
		Force32 = 2147483647,
	}

	public enum WGPUFilterMode
	{
		Undefined = 0,
		Nearest = 1,
		Linear = 2,
		Force32 = 2147483647,
	}

	public enum WGPUFrontFace
	{
		Undefined = 0,
		CCW = 1,
		CW = 2,
		Force32 = 2147483647,
	}

	public enum WGPUIndexFormat
	{
		Undefined = 0,
		Uint16 = 1,
		Uint32 = 2,
		Force32 = 2147483647,
	}

	public enum WGPULoadOp
	{
		Undefined = 0,
		Clear = 1,
		Load = 2,
		Force32 = 2147483647,
	}

	public enum WGPUMipmapFilterMode
	{
		Undefined = 0,
		Nearest = 1,
		Linear = 2,
		Force32 = 2147483647,
	}

	public enum WGPUPowerPreference
	{
		Undefined = 0,
		LowPower = 1,
		HighPerformance = 2,
		Force32 = 2147483647,
	}

	public enum WGPUPresentMode
	{
		Fifo = 1,
		Immediate = 3,
		Mailbox = 4,
		Force32 = 2147483647,
	}

	public enum WGPUPrimitiveTopology
	{
		Undefined = 0,
		PointList = 1,
		LineList = 2,
		LineStrip = 3,
		TriangleList = 4,
		TriangleStrip = 5,
		Force32 = 2147483647,
	}

	public enum WGPUQueryType
	{
		Occlusion = 1,
		Timestamp = 2,
		Force32 = 2147483647,
	}

	public enum WGPUQueueWorkDoneStatus
	{
		Success = 0,
		Error = 1,
		Unknown = 2,
		DeviceLost = 3,
		Force32 = 2147483647,
	}

	public enum WGPURequestAdapterStatus
	{
		Success = 0,
		Unavailable = 1,
		Error = 2,
		Unknown = 3,
		Force32 = 2147483647,
	}

	public enum WGPURequestDeviceStatus
	{
		Success = 0,
		Error = 1,
		Unknown = 2,
		Force32 = 2147483647,
	}

	public enum WGPUSType
	{
		Invalid = 0,
		SurfaceDescriptorFromCanvasHTMLSelector = 4,
		ShaderModuleSPIRVDescriptor = 5,
		ShaderModuleWGSLDescriptor = 6,
		PrimitiveDepthClipControl = 7,
		RenderPassDescriptorMaxDrawCount = 15,
		TextureBindingViewDimensionDescriptor = 17,
		Force32 = 2147483647,
	}

	public enum WGPUSamplerBindingType
	{
		Undefined = 0,
		Filtering = 1,
		NonFiltering = 2,
		Comparison = 3,
		Force32 = 2147483647,
	}

	public enum WGPUStencilOperation
	{
		Undefined = 0,
		Keep = 1,
		Zero = 2,
		Replace = 3,
		Invert = 4,
		IncrementClamp = 5,
		DecrementClamp = 6,
		IncrementWrap = 7,
		DecrementWrap = 8,
		Force32 = 2147483647,
	}

	public enum WGPUStorageTextureAccess
	{
		Undefined = 0,
		WriteOnly = 1,
		ReadOnly = 2,
		ReadWrite = 3,
		Force32 = 2147483647,
	}

	public enum WGPUStoreOp
	{
		Undefined = 0,
		Store = 1,
		Discard = 2,
		Force32 = 2147483647,
	}

	public enum WGPUTextureAspect
	{
		Undefined = 0,
		All = 1,
		StencilOnly = 2,
		DepthOnly = 3,
		Force32 = 2147483647,
	}

	public enum WGPUTextureDimension
	{
		Undefined = 0,
		_1D = 1,
		_2D = 2,
		_3D = 3,
		Force32 = 2147483647,
	}

	public enum WGPUTextureFormat
	{
		Undefined = 0,
		R8Unorm = 1,
		R8Snorm = 2,
		R8Uint = 3,
		R8Sint = 4,
		R16Uint = 5,
		R16Sint = 6,
		R16Float = 7,
		RG8Unorm = 8,
		RG8Snorm = 9,
		RG8Uint = 10,
		RG8Sint = 11,
		R32Float = 12,
		R32Uint = 13,
		R32Sint = 14,
		RG16Uint = 15,
		RG16Sint = 16,
		RG16Float = 17,
		RGBA8Unorm = 18,
		RGBA8UnormSrgb = 19,
		RGBA8Snorm = 20,
		RGBA8Uint = 21,
		RGBA8Sint = 22,
		BGRA8Unorm = 23,
		BGRA8UnormSrgb = 24,
		RGB10A2Uint = 25,
		RGB10A2Unorm = 26,
		RG11B10Ufloat = 27,
		RGB9E5Ufloat = 28,
		RG32Float = 29,
		RG32Uint = 30,
		RG32Sint = 31,
		RGBA16Uint = 32,
		RGBA16Sint = 33,
		RGBA16Float = 34,
		RGBA32Float = 35,
		RGBA32Uint = 36,
		RGBA32Sint = 37,
		Stencil8 = 38,
		Depth16Unorm = 39,
		Depth24Plus = 40,
		Depth24PlusStencil8 = 41,
		Depth32Float = 42,
		Depth32FloatStencil8 = 43,
		BC1RGBAUnorm = 44,
		BC1RGBAUnormSrgb = 45,
		BC2RGBAUnorm = 46,
		BC2RGBAUnormSrgb = 47,
		BC3RGBAUnorm = 48,
		BC3RGBAUnormSrgb = 49,
		BC4RUnorm = 50,
		BC4RSnorm = 51,
		BC5RGUnorm = 52,
		BC5RGSnorm = 53,
		BC6HRGBUfloat = 54,
		BC6HRGBFloat = 55,
		BC7RGBAUnorm = 56,
		BC7RGBAUnormSrgb = 57,
		ETC2RGB8Unorm = 58,
		ETC2RGB8UnormSrgb = 59,
		ETC2RGB8A1Unorm = 60,
		ETC2RGB8A1UnormSrgb = 61,
		ETC2RGBA8Unorm = 62,
		ETC2RGBA8UnormSrgb = 63,
		EACR11Unorm = 64,
		EACR11Snorm = 65,
		EACRG11Unorm = 66,
		EACRG11Snorm = 67,
		ASTC4x4Unorm = 68,
		ASTC4x4UnormSrgb = 69,
		ASTC5x4Unorm = 70,
		ASTC5x4UnormSrgb = 71,
		ASTC5x5Unorm = 72,
		ASTC5x5UnormSrgb = 73,
		ASTC6x5Unorm = 74,
		ASTC6x5UnormSrgb = 75,
		ASTC6x6Unorm = 76,
		ASTC6x6UnormSrgb = 77,
		ASTC8x5Unorm = 78,
		ASTC8x5UnormSrgb = 79,
		ASTC8x6Unorm = 80,
		ASTC8x6UnormSrgb = 81,
		ASTC8x8Unorm = 82,
		ASTC8x8UnormSrgb = 83,
		ASTC10x5Unorm = 84,
		ASTC10x5UnormSrgb = 85,
		ASTC10x6Unorm = 86,
		ASTC10x6UnormSrgb = 87,
		ASTC10x8Unorm = 88,
		ASTC10x8UnormSrgb = 89,
		ASTC10x10Unorm = 90,
		ASTC10x10UnormSrgb = 91,
		ASTC12x10Unorm = 92,
		ASTC12x10UnormSrgb = 93,
		ASTC12x12Unorm = 94,
		ASTC12x12UnormSrgb = 95,
		Force32 = 2147483647,
	}

	public enum WGPUTextureSampleType
	{
		Undefined = 0,
		Float = 1,
		UnfilterableFloat = 2,
		Depth = 3,
		Sint = 4,
		Uint = 5,
		Force32 = 2147483647,
	}

	public enum WGPUTextureViewDimension
	{
		Undefined = 0,
		_1D = 1,
		_2D = 2,
		_2DArray = 3,
		Cube = 4,
		CubeArray = 5,
		_3D = 6,
		Force32 = 2147483647,
	}

	public enum WGPUVertexFormat
	{
		Undefined = 0,
		Uint8x2 = 1,
		Uint8x4 = 2,
		Sint8x2 = 3,
		Sint8x4 = 4,
		Unorm8x2 = 5,
		Unorm8x4 = 6,
		Snorm8x2 = 7,
		Snorm8x4 = 8,
		Uint16x2 = 9,
		Uint16x4 = 10,
		Sint16x2 = 11,
		Sint16x4 = 12,
		Unorm16x2 = 13,
		Unorm16x4 = 14,
		Snorm16x2 = 15,
		Snorm16x4 = 16,
		Float16x2 = 17,
		Float16x4 = 18,
		Float32 = 19,
		Float32x2 = 20,
		Float32x3 = 21,
		Float32x4 = 22,
		Uint32 = 23,
		Uint32x2 = 24,
		Uint32x3 = 25,
		Uint32x4 = 26,
		Sint32 = 27,
		Sint32x2 = 28,
		Sint32x3 = 29,
		Sint32x4 = 30,
		Unorm10 = 31,
		Force32 = 2147483647,
	}

	public enum WGPUVertexStepMode
	{
		Undefined = 0,
		VertexBufferNotUsed = 1,
		Vertex = 2,
		Instance = 3,
		Force32 = 2147483647,
	}

	public enum WGPUWaitStatus
	{
		Success = 0,
		TimedOut = 1,
		UnsupportedTimeout = 2,
		UnsupportedCount = 3,
		UnsupportedMixedSources = 4,
		Unknown = 5,
		Force32 = 2147483647,
	}

	[Flags]
	public enum WGPUBufferUsage
	{
		None = 0,
		MapRead = 1,
		MapWrite = 2,
		CopySrc = 4,
		CopyDst = 8,
		Index = 16,
		Vertex = 32,
		Uniform = 64,
		Storage = 128,
		Indirect = 256,
		QueryResolve = 512,
		Force32 = 2147483647,
	}

	[Flags]
	public enum WGPUColorWriteMask
	{
		None = 0,
		Red = 1,
		Green = 2,
		Blue = 4,
		Alpha = 8,
		All = 15,
		Force32 = 2147483647,
	}

	[Flags]
	public enum WGPUMapMode
	{
		None = 0,
		Read = 1,
		Write = 2,
		Force32 = 2147483647,
	}

	[Flags]
	public enum WGPUShaderStage
	{
		None = 0,
		Vertex = 1,
		Fragment = 2,
		Compute = 4,
		Force32 = 2147483647,
	}

	[Flags]
	public enum WGPUTextureUsage
	{
		None = 0,
		CopySrc = 1,
		CopyDst = 2,
		TextureBinding = 4,
		StorageBinding = 8,
		RenderAttachment = 16,
		Force32 = 2147483647,
	}

}
