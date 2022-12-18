<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128571780/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T233956)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* **[MainWindow.xaml](./CS/CartesianMap/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/CartesianMap/MainWindow.xaml))**
* [MainWindow.xaml.cs](./CS/CartesianMap/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/CartesianMap/MainWindow.xaml.vb))
<!-- default file list end -->
# How to provide a Cartesian vector map for the Map Control


This example demonstrates how to load Cartesian vector map data to the Map Control.


<h3>Description</h3>

<p>To load a vector Cartesian map, do the following.</p>
<p>1. Crete a <a href="https://documentation.devexpress.com/#WPF/clsDevExpressXpfMapShapefileDataAdaptertopic">ShapefileDataAdapter</a> object.</p>
<p>2. Set its <strong>CoordinateSystemDataAdapterBase.SourceCoordinateSystem</strong> property to a <strong>CartesianSourceCoordinateSystem</strong> object.</p>
<p>3. Specify its <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfMapShapefileLoader_FileUritopic">FileDataAdapterBase.FileUri</a> property.</p>
<p>4. Assign this object to the <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfMapVectorLayer_Datatopic">VectorLayer.Data</a> property.</p>

<br/>


