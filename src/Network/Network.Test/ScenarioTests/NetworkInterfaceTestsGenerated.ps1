﻿# <auto-generated>
# Copyright (c) Microsoft and contributors.  All rights reserved.
# 
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
#   http://www.apache.org/licenses/LICENSE-2.0
# 
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# 
# See the License for the specific language governing permissions and
# limitations under the License.
# 
# 
# Warning: This code was generated by a tool.
# 
# Changes to this file may cause incorrect behavior and will be lost if the
# code is regenerated.
# 
# For documentation on code generator please visit
#   https://aka.ms/nrp-code-generation
# Please contact wanrpdev@microsoft.com if you need to make changes to this file.
# </auto-generated>

function Check-CmdletReturnType
{
    param($cmdletName, $cmdletReturn)

    $cmdletData = Get-Command $cmdletName;
    Assert-NotNull $cmdletData;
    [array]$cmdletReturnTypes = $cmdletData.OutputType.Name | Foreach-Object { return ($_ -replace "Microsoft.Azure.Commands.Network.Models.","") };
    [array]$cmdletReturnTypes = $cmdletReturnTypes | Foreach-Object { return ($_ -replace "System.","") };
    $realReturnType = $cmdletReturn.GetType().Name -replace "Microsoft.Azure.Commands.Network.Models.","";
    return $cmdletReturnTypes -contains $realReturnType;
}

<#
.SYNOPSIS
Test creating new NetworkInterface using minimal set of parameters
#>
function Test-NetworkInterfaceCRUDMinimalParameters
{
    # Setup
    $rgname = Get-ResourceGroupName;
    $rglocation = Get-ProviderLocation ResourceManagement;
    $rname = Get-ResourceName;
    $location = Get-ProviderLocation "Microsoft.Network/networkInterfaces" "West Central US";
    # Dependency parameters
    $SubnetName = "SubnetName";
    $SubnetAddressPrefix = "10.0.1.0/24";
    $VirtualNetworkName = "VirtualNetworkName";
    $VirtualNetworkAddressPrefix = @("10.0.0.0/8");

    try
    {
        $resourceGroup = New-AzResourceGroup -Name $rgname -Location $rglocation;

        # Create required dependencies
        $Subnet = New-AzVirtualNetworkSubnetConfig -Name $SubnetName -AddressPrefix $SubnetAddressPrefix;
        $VirtualNetwork = New-AzVirtualNetwork -ResourceGroupName $rgname -Location $location -Name $VirtualNetworkName -Subnet $Subnet -AddressPrefix $VirtualNetworkAddressPrefix;
        if(-not $Subnet.Id)
        {
            $Subnet = Get-AzVirtualNetworkSubnetConfig -Name $SubnetName -VirtualNetwork $VirtualNetwork;
        }

        # Create NetworkInterface
        $vNetworkInterface = New-AzNetworkInterface -ResourceGroupName $rgname -Name $rname -Location $location -Subnet $Subnet;
        Assert-NotNull $vNetworkInterface;
        Assert-True { Check-CmdletReturnType "New-AzNetworkInterface" $vNetworkInterface };
        $vIpConfiguration = $vNetworkInterface.IpConfigurations | Where-Object { $_.Name -eq "ipconfig1" };
        Assert-NotNull $vIpConfiguration;
        Assert-NotNull $vIpConfiguration.Subnet;
        Assert-AreEqual $rname $vNetworkInterface.Name;

        # Get NetworkInterface
        $vNetworkInterface = Get-AzNetworkInterface -ResourceGroupName $rgname -Name $rname;
        Assert-NotNull $vNetworkInterface;
        Assert-True { Check-CmdletReturnType "Get-AzNetworkInterface" $vNetworkInterface };
        Assert-AreEqual $rname $vNetworkInterface.Name;

        # Get all NetworkInterfaces in resource group
        $listNetworkInterface = Get-AzNetworkInterface -ResourceGroupName $rgname;
        Assert-NotNull ($listNetworkInterface | Where-Object { $_.ResourceGroupName -eq $rgname -and $_.Name -eq $rname });

        # Get all NetworkInterfaces in subscription
        $listNetworkInterface = Get-AzNetworkInterface;
        Assert-NotNull ($listNetworkInterface | Where-Object { $_.ResourceGroupName -eq $rgname -and $_.Name -eq $rname });

        # Get all NetworkInterfaces in subscription wildcard for resource group
        $listNetworkInterface = Get-AzNetworkInterface -ResourceGroupName "*";
        Assert-NotNull ($listNetworkInterface | Where-Object { $_.ResourceGroupName -eq $rgname -and $_.Name -eq $rname });

        # Get all NetworkInterfaces in subscription wildcard for name
        $listNetworkInterface = Get-AzNetworkInterface -Name "*";
        Assert-NotNull ($listNetworkInterface | Where-Object { $_.ResourceGroupName -eq $rgname -and $_.Name -eq $rname });

        # Get all NetworkInterfaces in subscription wildcard for both resource group and name
        $listNetworkInterface = Get-AzNetworkInterface -ResourceGroupName "*" -Name "*";
        Assert-NotNull ($listNetworkInterface | Where-Object { $_.ResourceGroupName -eq $rgname -and $_.Name -eq $rname });

        # Remove NetworkInterface
        $job = Remove-AzNetworkInterface -ResourceGroupName $rgname -Name $rname -PassThru -Force -AsJob;
        $job | Wait-Job;
        $removeNetworkInterface = $job | Receive-Job;
        Assert-AreEqual $true $removeNetworkInterface;

        # Get NetworkInterface should fail
        Assert-ThrowsContains { Get-AzNetworkInterface -ResourceGroupName $rgname -Name $rname } "not found";
    }
    finally
    {
        # Cleanup
        Clean-ResourceGroup $rgname;
    }
}

<#
.SYNOPSIS
Test creating new NetworkInterface
#>
function Test-NetworkInterfaceCRUDAllParameters
{
    # Setup
    $rgname = Get-ResourceGroupName;
    $rglocation = Get-ProviderLocation ResourceManagement;
    $rname = Get-ResourceName;
    $location = Get-ProviderLocation "Microsoft.Network/networkInterfaces" "West Central US";
    # Resource's parameters
    $PrivateIPAddress = "10.0.1.42";
    $IpConfigurationName = "createipconf";
    $InternalDnsNameLabel = "internal-dns-foo";
    $EnableAcceleratedNetworking = $false;
    $EnableIPForwarding = $false;
    # Resource's parameters for Set test
    $InternalDnsNameLabelSet = "internal-dns-bar";
    $EnableAcceleratedNetworkingSet = $true;
    $EnableIPForwardingSet = $true;
    # Dependency parameters
    $SubnetName = "SubnetName";
    $SubnetAddressPrefix = "10.0.1.0/24";
    $VirtualNetworkName = "VirtualNetworkName";
    $VirtualNetworkAddressPrefix = @("10.0.0.0/8");
    $PublicIPAddressName = "PublicIPAddressName";
    $PublicIPAddressAllocationMethod = "Static";

    try
    {
        $resourceGroup = New-AzResourceGroup -Name $rgname -Location $rglocation;

        # Create required dependencies
        $Subnet = New-AzVirtualNetworkSubnetConfig -Name $SubnetName -AddressPrefix $SubnetAddressPrefix;
        $VirtualNetwork = New-AzVirtualNetwork -ResourceGroupName $rgname -Location $location -Name $VirtualNetworkName -Subnet $Subnet -AddressPrefix $VirtualNetworkAddressPrefix;
        if(-not $Subnet.Id)
        {
            $Subnet = Get-AzVirtualNetworkSubnetConfig -Name $SubnetName -VirtualNetwork $VirtualNetwork;
        }
        $PublicIPAddress = New-AzPublicIPAddress -ResourceGroupName $rgname -Location $location -Name $PublicIPAddressName -AllocationMethod $PublicIPAddressAllocationMethod;

        # Create NetworkInterface
        $vNetworkInterface = New-AzNetworkInterface -ResourceGroupName $rgname -Name $rname -Location $location -Subnet $Subnet -PublicIPAddress $PublicIPAddress -PrivateIPAddress $PrivateIPAddress -IpConfigurationName $IpConfigurationName -InternalDnsNameLabel $InternalDnsNameLabel;
        Assert-NotNull $vNetworkInterface;
        Assert-True { Check-CmdletReturnType "New-AzNetworkInterface" $vNetworkInterface };
        $vIpConfiguration = $vNetworkInterface.IpConfigurations | Where-Object { $_.Name -eq $IpConfigurationName };
        Assert-NotNull $vIpConfiguration;
        Assert-NotNull $vIpConfiguration.Subnet;
        Assert-NotNull $vIpConfiguration.PublicIPAddress;
        Assert-AreEqual $rname $vNetworkInterface.Name;
        Assert-AreEqual $PrivateIPAddress $vNetworkInterface.IpConfigurations[0].PrivateIpAddress;
        Assert-AreEqual $IpConfigurationName $vNetworkInterface.IpConfigurations[0].Name;
        Assert-AreEqual $InternalDnsNameLabel $vNetworkInterface.DnsSettings.InternalDnsNameLabel;
        Assert-AreEqual $EnableAcceleratedNetworking $vNetworkInterface.EnableAcceleratedNetworking;
        Assert-AreEqual $EnableIPForwarding $vNetworkInterface.EnableIPForwarding;

        # Get NetworkInterface
        $vNetworkInterface = Get-AzNetworkInterface -ResourceGroupName $rgname -Name $rname;
        Assert-NotNull $vNetworkInterface;
        Assert-True { Check-CmdletReturnType "Get-AzNetworkInterface" $vNetworkInterface };
        Assert-AreEqual $rname $vNetworkInterface.Name;
        Assert-AreEqual $PrivateIPAddress $vNetworkInterface.IpConfigurations[0].PrivateIpAddress;
        Assert-AreEqual $IpConfigurationName $vNetworkInterface.IpConfigurations[0].Name;
        Assert-AreEqual $InternalDnsNameLabel $vNetworkInterface.DnsSettings.InternalDnsNameLabel;
        Assert-AreEqual $EnableAcceleratedNetworking $vNetworkInterface.EnableAcceleratedNetworking;
        Assert-AreEqual $EnableIPForwarding $vNetworkInterface.EnableIPForwarding;

        # Get all NetworkInterfaces in resource group
        $listNetworkInterface = Get-AzNetworkInterface -ResourceGroupName $rgname;
        Assert-NotNull ($listNetworkInterface | Where-Object { $_.ResourceGroupName -eq $rgname -and $_.Name -eq $rname });

        # Get all NetworkInterfaces in subscription
        $listNetworkInterface = Get-AzNetworkInterface;
        Assert-NotNull ($listNetworkInterface | Where-Object { $_.ResourceGroupName -eq $rgname -and $_.Name -eq $rname });

        # Get all NetworkInterfaces in subscription wildcard for resource group
        $listNetworkInterface = Get-AzNetworkInterface -ResourceGroupName "*";
        Assert-NotNull ($listNetworkInterface | Where-Object { $_.ResourceGroupName -eq $rgname -and $_.Name -eq $rname });

        # Get all NetworkInterfaces in subscription wildcard for name
        $listNetworkInterface = Get-AzNetworkInterface -Name "*";
        Assert-NotNull ($listNetworkInterface | Where-Object { $_.ResourceGroupName -eq $rgname -and $_.Name -eq $rname });

        # Get all NetworkInterfaces in subscription wildcard for both resource group and name
        $listNetworkInterface = Get-AzNetworkInterface -ResourceGroupName "*" -Name "*";
        Assert-NotNull ($listNetworkInterface | Where-Object { $_.ResourceGroupName -eq $rgname -and $_.Name -eq $rname });

        # Set NetworkInterface
        $vNetworkInterface.DnsSettings.InternalDnsNameLabel = $InternalDnsNameLabelSet;
        $vNetworkInterface.EnableAcceleratedNetworking = $EnableAcceleratedNetworkingSet;
        $vNetworkInterface.EnableIPForwarding = $EnableIPForwardingSet;
        $vNetworkInterface = Set-AzNetworkInterface -NetworkInterface $vNetworkInterface;
        Assert-NotNull $vNetworkInterface;
        Assert-True { Check-CmdletReturnType "Set-AzNetworkInterface" $vNetworkInterface };
        Assert-AreEqual $rname $vNetworkInterface.Name;
        Assert-AreEqual $InternalDnsNameLabelSet $vNetworkInterface.DnsSettings.InternalDnsNameLabel;
        Assert-AreEqual $EnableAcceleratedNetworkingSet $vNetworkInterface.EnableAcceleratedNetworking;
        Assert-AreEqual $EnableIPForwardingSet $vNetworkInterface.EnableIPForwarding;

        # Get NetworkInterface
        $vNetworkInterface = Get-AzNetworkInterface -ResourceGroupName $rgname -Name $rname;
        Assert-NotNull $vNetworkInterface;
        Assert-True { Check-CmdletReturnType "Get-AzNetworkInterface" $vNetworkInterface };
        Assert-AreEqual $rname $vNetworkInterface.Name;
        Assert-AreEqual $InternalDnsNameLabelSet $vNetworkInterface.DnsSettings.InternalDnsNameLabel;
        Assert-AreEqual $EnableAcceleratedNetworkingSet $vNetworkInterface.EnableAcceleratedNetworking;
        Assert-AreEqual $EnableIPForwardingSet $vNetworkInterface.EnableIPForwarding;

        # Get all NetworkInterfaces in resource group
        $listNetworkInterface = Get-AzNetworkInterface -ResourceGroupName $rgname;
        Assert-NotNull ($listNetworkInterface | Where-Object { $_.ResourceGroupName -eq $rgname -and $_.Name -eq $rname });

        # Get all NetworkInterfaces in subscription
        $listNetworkInterface = Get-AzNetworkInterface;
        Assert-NotNull ($listNetworkInterface | Where-Object { $_.ResourceGroupName -eq $rgname -and $_.Name -eq $rname });

        # Get all NetworkInterfaces in subscription wildcard for resource group
        $listNetworkInterface = Get-AzNetworkInterface -ResourceGroupName "*";
        Assert-NotNull ($listNetworkInterface | Where-Object { $_.ResourceGroupName -eq $rgname -and $_.Name -eq $rname });

        # Get all NetworkInterfaces in subscription wildcard for name
        $listNetworkInterface = Get-AzNetworkInterface -Name "*";
        Assert-NotNull ($listNetworkInterface | Where-Object { $_.ResourceGroupName -eq $rgname -and $_.Name -eq $rname });

        # Get all NetworkInterfaces in subscription wildcard for both resource group and name
        $listNetworkInterface = Get-AzNetworkInterface -ResourceGroupName "*" -Name "*";
        Assert-NotNull ($listNetworkInterface | Where-Object { $_.ResourceGroupName -eq $rgname -and $_.Name -eq $rname });

        # Remove NetworkInterface
        $job = Remove-AzNetworkInterface -ResourceGroupName $rgname -Name $rname -PassThru -Force -AsJob;
        $job | Wait-Job;
        $removeNetworkInterface = $job | Receive-Job;
        Assert-AreEqual $true $removeNetworkInterface;

        # Get NetworkInterface should fail
        Assert-ThrowsContains { Get-AzNetworkInterface -ResourceGroupName $rgname -Name $rname } "not found";

        # Set NetworkInterface should fail
        Assert-ThrowsContains { Set-AzNetworkInterface -NetworkInterface $vNetworkInterface } "not found";
    }
    finally
    {
        # Cleanup
        Clean-ResourceGroup $rgname;
    }
}

<#
.SYNOPSIS
Test creating new NetworkInterfaceIpConfiguration using minimal set of parameters
#>
function Test-NetworkInterfaceIpConfigurationCRUDMinimalParameters
{
    # Setup
    $rgname = Get-ResourceGroupName;
    $rglocation = Get-ProviderLocation ResourceManagement;
    $rname = Get-ResourceName;
    $rnameAdd = "${rname}Add";
    $location = Get-ProviderLocation "Microsoft.Network/networkInterfaces" "West Central US";
    # Dependency parameters
    $SubnetName = "SubnetName";
    $SubnetAddressPrefix = "10.0.1.0/24";
    $VirtualNetworkName = "VirtualNetworkName";
    $VirtualNetworkAddressPrefix = @("10.0.0.0/8");

    try
    {
        $resourceGroup = New-AzResourceGroup -Name $rgname -Location $rglocation;

        # Create required dependencies
        $Subnet = New-AzVirtualNetworkSubnetConfig -Name $SubnetName -AddressPrefix $SubnetAddressPrefix;
        $VirtualNetwork = New-AzVirtualNetwork -ResourceGroupName $rgname -Location $location -Name $VirtualNetworkName -Subnet $Subnet -AddressPrefix $VirtualNetworkAddressPrefix;
        if(-not $Subnet.Id)
        {
            $Subnet = Get-AzVirtualNetworkSubnetConfig -Name $SubnetName -VirtualNetwork $VirtualNetwork;
        }

        # Create NetworkInterfaceIpConfiguration
        $vNetworkInterfaceIpConfiguration = New-AzNetworkInterfaceIpConfig -Name $rname -Subnet $Subnet;
        Assert-NotNull $vNetworkInterfaceIpConfiguration;
        Assert-True { Check-CmdletReturnType "New-AzNetworkInterfaceIpConfig" $vNetworkInterfaceIpConfiguration };
        $vNetworkInterface = New-AzNetworkInterface -ResourceGroupName $rgname -Name $rname -IpConfiguration $vNetworkInterfaceIpConfiguration -Location $location;
        Assert-NotNull $vNetworkInterface;
        Assert-AreEqual $rname $vNetworkInterfaceIpConfiguration.Name;

        # Get NetworkInterfaceIpConfiguration
        $vNetworkInterfaceIpConfiguration = Get-AzNetworkInterfaceIpConfig -NetworkInterface $vNetworkInterface -Name $rname;
        Assert-NotNull $vNetworkInterfaceIpConfiguration;
        Assert-True { Check-CmdletReturnType "Get-AzNetworkInterfaceIpConfig" $vNetworkInterfaceIpConfiguration };
        Assert-AreEqual $rname $vNetworkInterfaceIpConfiguration.Name;

        # Get all NetworkInterface's NetworkInterfaceIpConfigurations
        $listNetworkInterfaceIpConfiguration = Get-AzNetworkInterfaceIpConfig -NetworkInterface $vNetworkInterface;
        Assert-NotNull ($listNetworkInterfaceIpConfiguration | Where-Object { $_.Name -eq $rname });

        # Set NetworkInterfaceIpConfiguration
        $vNetworkInterface = Set-AzNetworkInterfaceIpConfig -Name $rname -NetworkInterface $vNetworkInterface -Subnet $Subnet;
        Assert-NotNull $vNetworkInterface;
        $vNetworkInterface = Set-AzNetworkInterface -NetworkInterface $vNetworkInterface;
        Assert-NotNull $vNetworkInterface;

        # Get NetworkInterfaceIpConfiguration
        $vNetworkInterfaceIpConfiguration = Get-AzNetworkInterfaceIpConfig -NetworkInterface $vNetworkInterface -Name $rname;
        Assert-NotNull $vNetworkInterfaceIpConfiguration;
        Assert-True { Check-CmdletReturnType "Get-AzNetworkInterfaceIpConfig" $vNetworkInterfaceIpConfiguration };
        Assert-AreEqual $rname $vNetworkInterfaceIpConfiguration.Name;

        # Get all NetworkInterface's NetworkInterfaceIpConfigurations
        $listNetworkInterfaceIpConfiguration = Get-AzNetworkInterfaceIpConfig -NetworkInterface $vNetworkInterface;
        Assert-NotNull ($listNetworkInterfaceIpConfiguration | Where-Object { $_.Name -eq $rname });

        # Add NetworkInterfaceIpConfiguration
        $vNetworkInterface = Add-AzNetworkInterfaceIpConfig -Name $rnameAdd -NetworkInterface $vNetworkInterface -SubnetId $Subnet.Id;
        Assert-NotNull $vNetworkInterface;
        $vNetworkInterface = Set-AzNetworkInterface -NetworkInterface $vNetworkInterface;
        Assert-NotNull $vNetworkInterface;

        # Get NetworkInterfaceIpConfiguration
        $vNetworkInterfaceIpConfiguration = Get-AzNetworkInterfaceIpConfig -NetworkInterface $vNetworkInterface -Name $rnameAdd;
        Assert-NotNull $vNetworkInterfaceIpConfiguration;
        Assert-True { Check-CmdletReturnType "Get-AzNetworkInterfaceIpConfig" $vNetworkInterfaceIpConfiguration };
        Assert-AreEqual $rnameAdd $vNetworkInterfaceIpConfiguration.Name;

        # Get all NetworkInterface's NetworkInterfaceIpConfigurations
        $listNetworkInterfaceIpConfiguration = Get-AzNetworkInterfaceIpConfig -NetworkInterface $vNetworkInterface;
        Assert-NotNull ($listNetworkInterfaceIpConfiguration | Where-Object { $_.Name -eq $rnameAdd });

        # Try Add again
        Assert-ThrowsContains { Add-AzNetworkInterfaceIpConfig -Name $rnameAdd -NetworkInterface $vNetworkInterface -SubnetId $Subnet.Id } "already exists";

        # Remove NetworkInterfaceIpConfiguration
        $vNetworkInterface = Remove-AzNetworkInterfaceIpConfig -NetworkInterface $vNetworkInterface -Name $rnameAdd;
        $vNetworkInterface = Set-AzNetworkInterface -NetworkInterface $vNetworkInterface;
        Assert-NotNull $vNetworkInterface;

        # Get NetworkInterfaceIpConfiguration should fail
        Assert-ThrowsContains { Get-AzNetworkInterfaceIpConfig -NetworkInterface $vNetworkInterface -Name $rnameAdd } "Sequence contains no matching element";

        # Set NetworkInterfaceIpConfiguration should fail
        Assert-ThrowsContains { Set-AzNetworkInterfaceIpConfig -Name $rnameAdd -NetworkInterface $vNetworkInterface -Subnet $Subnet } "does not exist";
    }
    finally
    {
        # Cleanup
        Clean-ResourceGroup $rgname;
    }
}

<#
.SYNOPSIS
Tests creating new simple public networkinterface with Gateway Loadbalancer.
#>
function Test-NetworkInterfaceGatewayLoadBalancerConsumer
{
    # Setup
    $rgname = Get-ResourceGroupName;

    $vnetProviderName = Get-ResourceName;
    $subnetProviderName = Get-ResourceName;
    $lbProviderName = Get-ResourceName;
    $frontendProviderName = Get-ResourceName;

    $vnetConsumerName = Get-ResourceName;
    $subnetConsumerName = Get-ResourceName;
    $publicIpConsumerName = Get-ResourceName;
    $nicConsumerName = Get-ResourceName;
    $ipconfigConsumerName = Get-ResourceName;
    $domainNameLabel = Get-ResourceName;
    $rglocation = Get-ProviderLocation ResourceManagement;
    $resourceTypeParent = "Microsoft.Network/networkInterfaces";
    $location = Get-ProviderLocation $resourceTypeParent;

    try 
    {
        # Create the resource group
        $resourceGroup = New-AzResourceGroup -Name $rgname -Location $rglocation -Tags @{ testtag = "testval" };

        # Create Provider Virtual Network
        $subnet = New-AzVirtualNetworkSubnetConfig -Name $subnetProviderName -AddressPrefix "10.0.1.0/24";
        $vnet = New-AzVirtualNetwork -Name $vnetProviderName -ResourceGroupName $rgname -Location $location -AddressPrefix "10.0.0.0/16" -Subnet $subnet;

        # Create Provider LoadBalancer
        $frontendProvider = New-AzLoadBalancerFrontendIpConfig -Name $frontendProviderName -Subnet $vnet.Subnets[0];
        $lbProvider = New-AzLoadBalancer -Name $lbProviderName -ResourceGroupName $rgname -Location $location -FrontendIpConfiguration $frontendProvider -Sku "Gateway";

        # Create Consumer Virtual Network
        $subnet = New-AzVirtualNetworkSubnetConfig -Name $subnetConsumerName -AddressPrefix "10.0.1.0/24";
        $vnet = New-AzVirtualNetwork -Name $vnetConsumerName -ResourceGroupName $rgname -Location $location -AddressPrefix "10.0.0.0/16" -Subnet $subnet;

        # Create Consumer publicip
        $publicipConsumer = New-AzPublicIpAddress -ResourceGroupName $rgname -name $publicIpConsumerName -Sku "Standard" -location $location -AllocationMethod Static;

	# Create the ipconfiguration
	$ipconfig1 = New-AzNetworkInterfaceIpConfig -Name $ipconfigConsumerName -Subnet $vnet.Subnets[0] -PublicIpAddress $publicipConsumer -GatewayLoadBalancerId $frontendProvider.Id;

        # Create NetworkInterface
        $nicConsumer = New-AzNetworkInterface -Name $nicConsumerName -ResourceGroupName $rgname -Location $location -IpConfiguration $ipconfig1 -Tag @{ testtag = "testval" };

        # Get NetworkInterface
        $expectedNicConsumer = Get-AzNetworkInterface -Name $nicConsumerName -ResourceGroupName $rgname;

        # Verification
        Assert-AreEqual $frontendProvider.Id $expectedNicConsumer.ipconfigurations[0].GatewayLoadBalancer.Id;   
    }
    finally
    {
        # Cleanup
        Clean-ResourceGroup $rgname;
    }
}

<#
.SYNOPSIS
Test creating new NetworkInterfaceIpConfiguration
#>
function Test-NetworkInterfaceIpConfigurationCRUDAllParameters
{
    # Setup
    $rgname = Get-ResourceGroupName;
    $rglocation = Get-ProviderLocation ResourceManagement;
    $rname = Get-ResourceName;
    $rnameAdd = "${rname}Add";
    $location = Get-ProviderLocation "Microsoft.Network/networkInterfaces" "West Central US";
    # Resource's parameters
    $PrivateIPAddress = "10.0.1.13";
    $PrivateIPAddressVersion = "IPv4";
    $Primary = $true;
    # Resource's parameters for Set test
    $PrivateIPAddressSet = "10.0.1.41";
    $PrimarySet = $true;
    # Resource's parameters for Add test
    $PrivateIPAddressAdd = "10.0.1.42";
    $PrimaryAdd = $false;
    # Dependency parameters
    $SubnetName = "SubnetName";
    $SubnetAddressPrefix = "10.0.1.0/24";
    $VirtualNetworkName = "VirtualNetworkName";
    $VirtualNetworkAddressPrefix = @("10.0.0.0/8");
    $PublicIPAddressName = "PublicIPAddressName";
    $PublicIPAddressAllocationMethod = "Static";

    try
    {
        $resourceGroup = New-AzResourceGroup -Name $rgname -Location $rglocation;

        # Create required dependencies
        $Subnet = New-AzVirtualNetworkSubnetConfig -Name $SubnetName -AddressPrefix $SubnetAddressPrefix;
        $VirtualNetwork = New-AzVirtualNetwork -ResourceGroupName $rgname -Location $location -Name $VirtualNetworkName -Subnet $Subnet -AddressPrefix $VirtualNetworkAddressPrefix;
        if(-not $Subnet.Id)
        {
            $Subnet = Get-AzVirtualNetworkSubnetConfig -Name $SubnetName -VirtualNetwork $VirtualNetwork;
        }
        $PublicIPAddress = New-AzPublicIPAddress -ResourceGroupName $rgname -Location $location -Name $PublicIPAddressName -AllocationMethod $PublicIPAddressAllocationMethod;

        # Create NetworkInterfaceIpConfiguration
        $vNetworkInterfaceIpConfiguration = New-AzNetworkInterfaceIpConfig -Name $rname -Subnet $Subnet -PublicIPAddress $PublicIPAddress -PrivateIPAddress $PrivateIPAddress -PrivateIPAddressVersion $PrivateIPAddressVersion -Primary;
        Assert-NotNull $vNetworkInterfaceIpConfiguration;
        Assert-True { Check-CmdletReturnType "New-AzNetworkInterfaceIpConfig" $vNetworkInterfaceIpConfiguration };
        $vNetworkInterface = New-AzNetworkInterface -ResourceGroupName $rgname -Name $rname -IpConfiguration $vNetworkInterfaceIpConfiguration -Location $location;
        Assert-NotNull $vNetworkInterface;
        Assert-AreEqual $rname $vNetworkInterfaceIpConfiguration.Name;
        Assert-AreEqual $PrivateIPAddress $vNetworkInterfaceIpConfiguration.PrivateIpAddress;
        Assert-AreEqual $PrivateIPAddressVersion $vNetworkInterfaceIpConfiguration.PrivateIpAddressVersion;
        Assert-AreEqual $Primary $vNetworkInterfaceIpConfiguration.Primary;

        # Get NetworkInterfaceIpConfiguration
        $vNetworkInterfaceIpConfiguration = Get-AzNetworkInterfaceIpConfig -NetworkInterface $vNetworkInterface -Name $rname;
        Assert-NotNull $vNetworkInterfaceIpConfiguration;
        Assert-True { Check-CmdletReturnType "Get-AzNetworkInterfaceIpConfig" $vNetworkInterfaceIpConfiguration };
        Assert-AreEqual $rname $vNetworkInterfaceIpConfiguration.Name;
        Assert-AreEqual $PrivateIPAddress $vNetworkInterfaceIpConfiguration.PrivateIpAddress;
        Assert-AreEqual $PrivateIPAddressVersion $vNetworkInterfaceIpConfiguration.PrivateIpAddressVersion;
        Assert-AreEqual $Primary $vNetworkInterfaceIpConfiguration.Primary;

        # Get all NetworkInterface's NetworkInterfaceIpConfigurations
        $listNetworkInterfaceIpConfiguration = Get-AzNetworkInterfaceIpConfig -NetworkInterface $vNetworkInterface;
        Assert-NotNull ($listNetworkInterfaceIpConfiguration | Where-Object { $_.Name -eq $rname });

        # Set NetworkInterfaceIpConfiguration
        $vNetworkInterface = Set-AzNetworkInterfaceIpConfig -Name $rname -NetworkInterface $vNetworkInterface -Subnet $Subnet -PrivateIPAddress $PrivateIPAddressSet -Primary;
        Assert-NotNull $vNetworkInterface;
        $vNetworkInterface = Set-AzNetworkInterface -NetworkInterface $vNetworkInterface;
        Assert-NotNull $vNetworkInterface;

        # Get NetworkInterfaceIpConfiguration
        $vNetworkInterfaceIpConfiguration = Get-AzNetworkInterfaceIpConfig -NetworkInterface $vNetworkInterface -Name $rname;
        Assert-NotNull $vNetworkInterfaceIpConfiguration;
        Assert-True { Check-CmdletReturnType "Get-AzNetworkInterfaceIpConfig" $vNetworkInterfaceIpConfiguration };
        Assert-AreEqual $rname $vNetworkInterfaceIpConfiguration.Name;
        Assert-AreEqual $PrivateIPAddressSet $vNetworkInterfaceIpConfiguration.PrivateIpAddress;
        Assert-AreEqual $PrimarySet $vNetworkInterfaceIpConfiguration.Primary;

        # Get all NetworkInterface's NetworkInterfaceIpConfigurations
        $listNetworkInterfaceIpConfiguration = Get-AzNetworkInterfaceIpConfig -NetworkInterface $vNetworkInterface;
        Assert-NotNull ($listNetworkInterfaceIpConfiguration | Where-Object { $_.Name -eq $rname });

        # Add NetworkInterfaceIpConfiguration
        $vNetworkInterface = Add-AzNetworkInterfaceIpConfig -Name $rnameAdd -NetworkInterface $vNetworkInterface -SubnetId $Subnet.Id -PublicIPAddressId $PublicIPAddress.Id -PrivateIPAddress $PrivateIPAddressAdd;
        Assert-NotNull $vNetworkInterface;
        $vNetworkInterface = Set-AzNetworkInterface -NetworkInterface $vNetworkInterface;
        Assert-NotNull $vNetworkInterface;

        # Get NetworkInterfaceIpConfiguration
        $vNetworkInterfaceIpConfiguration = Get-AzNetworkInterfaceIpConfig -NetworkInterface $vNetworkInterface -Name $rnameAdd;
        Assert-NotNull $vNetworkInterfaceIpConfiguration;
        Assert-True { Check-CmdletReturnType "Get-AzNetworkInterfaceIpConfig" $vNetworkInterfaceIpConfiguration };
        Assert-AreEqual $rnameAdd $vNetworkInterfaceIpConfiguration.Name;
        Assert-AreEqual $PrivateIPAddressAdd $vNetworkInterfaceIpConfiguration.PrivateIpAddress;
        Assert-AreEqual $PrimaryAdd $vNetworkInterfaceIpConfiguration.Primary;

        # Get all NetworkInterface's NetworkInterfaceIpConfigurations
        $listNetworkInterfaceIpConfiguration = Get-AzNetworkInterfaceIpConfig -NetworkInterface $vNetworkInterface;
        Assert-NotNull ($listNetworkInterfaceIpConfiguration | Where-Object { $_.Name -eq $rnameAdd });

        # Try Add again
        Assert-ThrowsContains { Add-AzNetworkInterfaceIpConfig -Name $rnameAdd -NetworkInterface $vNetworkInterface -SubnetId $Subnet.Id -PublicIPAddressId $PublicIPAddress.Id -PrivateIPAddress $PrivateIPAddressAdd } "already exists";

        # Remove NetworkInterfaceIpConfiguration
        $vNetworkInterface = Remove-AzNetworkInterfaceIpConfig -NetworkInterface $vNetworkInterface -Name $rnameAdd;
        $vNetworkInterface = Set-AzNetworkInterface -NetworkInterface $vNetworkInterface;
        Assert-NotNull $vNetworkInterface;

        # Get NetworkInterfaceIpConfiguration should fail
        Assert-ThrowsContains { Get-AzNetworkInterfaceIpConfig -NetworkInterface $vNetworkInterface -Name $rnameAdd } "Sequence contains no matching element";

        # Set NetworkInterfaceIpConfiguration should fail
        Assert-ThrowsContains { Set-AzNetworkInterfaceIpConfig -Name $rnameAdd -NetworkInterface $vNetworkInterface -Subnet $Subnet -PrivateIPAddress $PrivateIPAddressSet -Primary } "does not exist";
    }
    finally
    {
        # Cleanup
        Clean-ResourceGroup $rgname;
    }
}

<#
.SYNOPSIS
NetworkInterface's operations GetEffectiveRouteTable and GetEffectiveNetworkSecurityGroups should pass
#>
function Test-NetworkInterfaceGetEffectiveRouteTable
{
    param
    (
        $basedir = "./"
    )

    . ($basedir + "/ScenarioTests/Utils/Import-GeneratedTestUtils.ps1")

    # Setup
    $rglocation = Get-ProviderLocation ResourceManagement;
    $rname = Get-ResourceName;
    # Parameters for Get-TestDeployment
    $rgName = Get-ResourceGroupName;
    $location = Get-ProviderLocation "Microsoft.Network/networkInterfaces" "West Central US";
    $virtualMachineName = Get-ResourceName;
    $storageAccountName = Get-ResourceName;
    $routeTableName = Get-ResourceName;
    $networkInterfaceName = Get-ResourceName;
    $networkSecurityGroupName = Get-ResourceName;
    $virtualNetworkName = Get-ResourceName;

    try
    {
        $resourceGroup = New-AzResourceGroup -Name $rgname -Location $rglocation;

        # Create required dependencies
        $env = Get-TestDeployment -rgName $rgName `
                                  -location $location `
                                  -virtualMachineName $virtualMachineName `
                                  -storageAccountName $storageAccountName `
                                  -routeTableName $routeTableName `
                                  -networkInterfaceName $networkInterfaceName `
                                  -networkSecurityGroupName $networkSecurityGroupName `
                                  -virtualNetworkName $virtualNetworkName;

        # Invoke cmdlet
        $job = Get-AzEffectiveRouteTable -ResourceGroupName $rgname -NetworkInterfaceName $env.networkInterfaceName -AsJob;
        $job | Wait-Job;
        $vEffectiveRouteTable = $job | Receive-Job;
        Assert-NotNull $vEffectiveRouteTable;
        Assert-True { Check-CmdletReturnType "Get-AzEffectiveRouteTable" $vEffectiveRouteTable };

        # Invoke pair cmdlet
        $vEffectiveNetworkSecurityGroups = Get-AzEffectiveNetworkSecurityGroup -ResourceGroupName $rgname -NetworkInterfaceName $env.networkInterfaceName;
        Assert-NotNull $vEffectiveNetworkSecurityGroups;
        Assert-True { Check-CmdletReturnType "Get-AzEffectiveNetworkSecurityGroup" $vEffectiveNetworkSecurityGroups };
    }
    finally
    {
        # Cleanup
        Clean-ResourceGroup $rgname;
    }
}
