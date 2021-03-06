// $nombredeproyecto$.cpp: define las funciones exportadas de la aplicación DLL.
//

#include "stdafx.h"
#include "C:\Users\Mario Flores JR\Documents\TrabajosEstructuraDatos1\TrabajosEstructuraDatos1\MetodosAeropuertos\MetodosAeropuertos\Header.h"
#include "C:\Users\Mario Flores JR\Documents\TrabajosEstructuraDatos1\TrabajosEstructuraDatos1\MetodosAeropuertos\MetodosAeropuertos\Body.cpp"
#include "C:\Users\Mario Flores JR\Documents\TrabajosEstructuraDatos1\TrabajosEstructuraDatos1\MetodosAeropuertos\MetodosAeropuertos\Edge.h"
#include "C:\Users\Mario Flores JR\Documents\TrabajosEstructuraDatos1\TrabajosEstructuraDatos1\MetodosAeropuertos\MetodosAeropuertos\Edge.cpp"
#include "C:\Users\Mario Flores JR\Documents\TrabajosEstructuraDatos1\TrabajosEstructuraDatos1\MetodosAeropuertos\MetodosAeropuertos\Vertex.cpp"
#include "C:\Users\Mario Flores JR\Documents\TrabajosEstructuraDatos1\TrabajosEstructuraDatos1\MetodosAeropuertos\MetodosAeropuertos\Vertex.h"

extern "C" __declspec(dllexport) void __stdcall Creat_Airport(char *name, double lat, double lon) {
	ProyectMethods pm;
	pm.Create_Airport(name, lat, lon);
}

extern "C" __declspec(dllexport) void __stdcall Read_Airport(char *buff, int pos) {
	ProyectMethods pm;
	pm.Read_Airport(buff, pos);
}


extern "C" __declspec(dllexport) int __stdcall Lenght_File() {
	ProyectMethods pm;
	return pm.Lenght_Arch();
}

extern "C" __declspec(dllexport) void __stdcall Delete_Airport(char * name) {
	ProyectMethods pm;
	pm.Delete_Airport(name);
}

extern "C" __declspec(dllexport) void __stdcall Update_Airport(char * name, char * newName, double lat, double lon) {
	ProyectMethods pm;
	pm.Update_Airport(name, newName, lat, lon);
}

extern "C" __declspec(dllexport) bool __stdcall Exist_Airport(char *name) {
	ProyectMethods pm;

	return pm.Exist_Airport(name);
}

extern "C" __declspec(dllexport) int __stdcall Create_route(char * id, char *rou) {
	ProyectMethods pm;
	return pm.Create_Route(id, rou);
}

extern "C" __declspec(dllexport) void __stdcall Read_Route(char *buff, int pos) {
	ProyectMethods pm;
	pm.Read_Route(buff, pos);
}
extern "C" __declspec(dllexport) void __stdcall Delete_Route(char *id, char *rou) {
	ProyectMethods pm;
	pm.Delete_Route(id, rou);
}
extern "C" __declspec(dllexport) void __stdcall Update_Route(char *id, char*rou, char*newR) {
	ProyectMethods pm;
	pm.Update_Route(id, rou, newR);
}
extern "C" __declspec(dllexport) int __stdcall Length_R() {
	ProyectMethods pm;
	return pm.Lenght_R(); 
}

extern "C" __declspec(dllexport) void __stdcall Update_IDroute(char *id, char*nID) {
	ProyectMethods pm;
	pm.Update_IDroute(id, nID);
}
extern "C" __declspec(dllexport) void __stdcall Delete_allIDRoutes(char *id) {
	ProyectMethods pm;
	pm.Delete_allIDroutes(id);
}

extern "C" __declspec(dllexport) void __stdcall Read_IDroutes(char *buff,int pos) {
	ProyectMethods pm;
	pm.readRutasID(buff, pos);
}

extern "C" __declspec(dllexport) void __stdcall Creat_IDroutes(char *org, char*des,int dis) {
	ProyectMethods pm;
	pm.createRutasID(org, des, dis);
}

extern "C" __declspec(dllexport) int __stdcall Lenght_IDroutes() {
	ProyectMethods pm;
	return pm.Lenght_IDrutas();
}

extern "C" __declspec(dllexport)void __stdcall getID(char*buff, char* nombreruta) {
	ProyectMethods pm;
	pm.getID(buff, nombreruta);
}

extern "C" __declspec(dllexport)double __stdcall getLat(char*id) {
	ProyectMethods pm;
	return pm.getLat(id);
}

extern "C" __declspec(dllexport)double __stdcall getLon(char*id) {
	ProyectMethods pm;
	return pm.getLng(id);
}

extern "C" __declspec(dllexport) int __stdcall getDist(char*org, char*des) {
	ProyectMethods pm;
	return pm.getDist(org, des);
}

extern "C" __declspec(dllexport)void __stdcall Delete_IDRoutes(char*id) {
	ProyectMethods pm;
	pm.borrarRutasID(id);
}
