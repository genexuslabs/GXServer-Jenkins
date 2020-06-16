# GXserver-Jenkins-Commit-Hooker
GXServer-Jenkins

## This repository contains:

An example of the implementation of the intermediate software for the communication between GX Server and Slack. 

The Event Dispatcher extension (installed on GX Server) is what listens to the commits of the KB an calls this intermediate software.

## Repository structure:

- GeneXus.Server.ExternalTool (it's the interface and should not be changed)
- GeneXus.Server.ExternalTool.Jenkins (implementation)

## Requirements

 - .NET Framework 4.7.1 or upper

## How to compile

 - Do a checkout
 - Check the .csproj file where it detemines where the compiled dll will be copied. In order to debug or run this solution the compiled dll has to be under the 
$(GX_SERVER_DIR)\BinGenexus folder.

## About Event Dispatcher extension

Event Dispatcher is an extension of GX Server (version management software) that allows, when a user commits to a KB published in
GX Server, communicate with third-party services (tools that allow continuous integration such as ticketing tools, or automation of assembly and testing, communication between developers, etc.).

It consists of the following dlls distributed by GXServer:

GeneXus.Packages.Server.EventsDispatcher.dll (under VDir\BinGenexus\Packages) 
GeneXus.Server.ExternalTool.dll (under VDir\BinGenexus)

It is a "listener" that when committing in any KB, reads a configuration file installed at that KB level, to determine which dlls
invoke. 
These dlls (intermediate software to be installed in GXServer in VDir\BinGenexus) will call the services
of each tool receiving from the extension all the commit information.


The intermediate software must be implemented in particular for each tool with which you want to interact, taking into account the API that the tool provides, and will
use that API to execute the actions you want.

This repository contains an example of the implementation of the intermediate software for Jenkins.

These intermediate software dlls must implement a pre-established interface which is included in the repository and should not be changed (GeneXus.Server.ExternalTool.dll).


# License

   Copyright 2020 GeneXus

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
