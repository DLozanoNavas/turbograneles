🚢 Turbograneles Application: .NET Aspire Environment Setup on Red Hat

This guide sets up a Red Hat Enterprise Linux (RHEL 9+) system to run the Turbograneles Application, a cloud-native solution built with .NET Aspire.

⸻

📦 Repository

Clone the official repository:

git clone https://github.com/DLozanoNavas/turbograneles.git
cd turbugraneles

⸻

⚙️ Environment Setup

The repository includes an automated setup script:

1. Make the Script Executable

chmod +x install-dotnet-aspire.sh

2. Run the Script

./install-dotnet-aspire.sh


⸻

🔁 Post-Install Step

Reboot or log out/in to apply Docker group permissions:

reboot
⸻

📄 Script Summary

The install-dotnet-aspire.sh script performs the following:
	•	Updates the system
	•	Installs development dependencies (wget, curl, unzip, git)
	•	Installs .NET 8 SDK
	•	Installs and enables Docker
	•	Installs the .NET Aspire workload

⸻

✅ Result

Your Red Hat environment will be ready to:
	•	Build and run the Turbograneles Application
	•	Use Docker for containerized microservices
	•	Develop and debug using .NET Aspire
