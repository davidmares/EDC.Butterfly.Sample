@echo off
title Tracing Service
echo [Tracing Service] Now starting to lanuch Butterfly-Web
cd /E E:/Projects/DNC/Manulife.DNC.MSAD/Manulife.DNC.MSAD.TracingCenter
dotnet Butterfly.Web.dll --EnableHttpCollector=true