# NYCDataAccessVisualization
## How GIS data turns into 3D Model using public data, NYC Open Data.

Virtual Reality may enable people of low vision and/or blind people walk on New York City streets and distinguish permanent infrastructures, such as commercial front doors, stairs, door knobs, street sign orders, bus stops, benches and more.

### Data Prep
[Permanent Infrastructure data]
- Street Sign Orders. It explains each name of streets, warning signs, directions and dead-ends. 
- Bus Stops
- Benches
- Hydrants
- Pedestrian Ramps
- News Stands
- Parking Meters

*Data is available on 'https://opendata.cityofnewyork.us/'. Use your keywords and search them in the main search box. Download the data in .csv type. 

[Trimming using Python]
- Drop out data if it is not located in Manhattan among five boroughs. Borough code for Manhattan: '1'.
- Designate coordinate points as geometry data in order to let GIS (QGIS) read and render the data. Python moduels: Geopandas and shapley.
- Save them as .csv or shapefile.
- Refer to file "Manhattan_Hydrants.ipynb"

### QGIS
[Render geometry data in QGIS and select 2x2 sample area]
- Import trimmed manhattan data. 
- Go to PLUTO 'https://chriswhong.github.io/plutoplus/#'. 1) Choose Area. (2x2) 2) Draw a polygon of desired area. 3) Download and import it into QGIS as a base map. Note if the coordinate system is corresponding. (epsg)
- Make sure the base map goes to the bottom. 
- Select each geometry data and draw a polygon following the base map. Save as selected area into csv files. (Hand drawing is availble in QGIS)
- Per each layer, you can select icon color or design.

I would rather recommend to go to the file "Manhattan_Access.qgz", select each layer and right click -> Export -> Save feature as -> select file type (could be anything, geojson, csv, and shapefile) -> select the location you want to save (must direct the location) -> name the file and save. The Qgis project includes all the data for Manhattan area.

Recomended Tutorials:


### UNITY3D
[Install UnityHub and VisualStudio]
- https://unity3d.com/get-unity/download
- https://visualstudio.microsoft.com/

Recomended Tutorials:




