#!/bin/bash

set -e

# Update system
sudo dnf update -y

# Install required dependencies
sudo dnf install -y wget curl unzip git

# Install .NET 8 SDK
echo "Installing .NET 8 SDK..."
sudo dnf install -y dotnet-sdk-9.0

# Verify installation
dotnet --version

# Install Docker
echo "Installing Docker..."
sudo dnf config-manager --add-repo https://download.docker.com/linux/centos/docker-ce.repo
sudo dnf install -y docker-ce docker-ce-cli containerd.io
sudo systemctl enable --now docker
sudo usermod -aG docker "$USER"

# Install .NET Aspire workload
echo "Installing .NET Aspire workload..."
dotnet workload install aspire

# Done
echo "✅ .NET Aspire is now installed and ready on your Red Hat system."
echo "⚠️ Please reboot or log out/in for Docker group changes to take effect."
