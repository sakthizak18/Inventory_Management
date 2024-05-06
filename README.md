# Inventory_Management
required softwares to run this project 
{
>.NET SDK [
>Windows:
Download: Visit the official .NET download page using your web browser.
Choose Version: Select the version of the .NET SDK you want to install. Generally, it's recommended to install the latest stable version.
Run Installer: Once the download is complete, run the downloaded installer file (.exe).
Follow Installation Wizard: The installation wizard will guide you through the installation process. Follow the prompts and select the desired installation options.
Verify Installation: After installation, open Command Prompt or PowerShell and type dotnet --version to verify that the .NET SDK is installed correctly.
>
>macOS:
Download: Visit the official .NET download page using your web browser.
Choose Version: Select the version of the .NET SDK you want to install. Generally, it's recommended to install the latest stable version.
Run Installer: Once the download is complete, run the downloaded installer file (.pkg).
Follow Installation Wizard: The installation wizard will guide you through the installation process. Follow the prompts and enter your macOS password when prompted.
Verify Installation: After installation, open Terminal and type dotnet --version to verify that the .NET SDK is installed correctly.
>
Linux (Ubuntu/Debian):
Register Microsoft Key and Feed: Run the following commands in your terminal:
bash
Copy code
wget https://packages.microsoft.com/config/ubuntu/20.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb
Install .NET SDK: Run the following commands in your terminal:
bash
Copy code
sudo apt-get update
sudo apt-get install -y apt-transport-https && sudo apt-get update && sudo apt-get install -y dotnet-sdk-5.0
Verify Installation: After installation, open your terminal and type dotnet --version to verify that the .NET SDK is installed correctly.
These steps should get you up and running with the .NET SDK on your respective operating system. Once installed, you can start developing ASP.NET applications using your preferred IDE or text editor.
>]
>Visual Studio is the recommended IDE.
>Web Server: ASP.NET projects typically run on Internet Information Services (IIS) on Windows. For development purposes, Visual Studio includes a built-in web server called IIS Express, which you can use during development.
>


>NOTE If you are using VScode as a IDE then follow these step to install required extentions.
>C# Extension for Visual Studio Code: Install the C# extension for Visual Studio Code. This extension provides IntelliSense, debugging, and other features for C# development in VSCode. You can install it directly from the Extensions view in VSCode or from the Visual Studio Code Marketplace.
>ASP.NET Core CLI (Optional): While not strictly necessary, having the ASP.NET Core CLI installed can be helpful for running commands related to ASP.NET Core projects directly from the terminal. You can install it by following the instructions provided on the official ASP.NET Core documentation.
>
