#pragma once

#ifdef BUILDING_DETECTENTRYPOINNOTFOUND_LIBRARY1
#define DETECTENTRYPOINNOTFOUND_LIBRARY1 __declspec(dllexport)
#else
#define DETECTENTRYPOINNOTFOUND_LIBRARY1 __declspec(dllimport)
#endif

//#ifdef _MSC_VER
//#pragma warning(disable: 4251)
//#endif