# NYCDataAccessVisualization
## How GIS data turns into 3D Model using public data, NYC Open Data.

Virtual Reality may enable people of low vision and/or blind people walk on New York City streets and distinguish permanent infrastructures, such as commercial front doors, stairs, doorknobs, street sign orders, bus stops, benches and more.

### Data Prep
[Permanent Infrastructure data]
- Street Sign Orders. It explains each name of streets, warning signs, directions, and dead ends. 
- Bus Stops
- Benches
- Hydrants
- Pedestrian Ramps
- News Stands
- Parking Meters

*Data is available on 'https://opendata.cityofnewyork.us/'. Use your keywords and search them in the main search box. Download the data in .csv type. 

[Trimming using Python]
- Drop out data if it is not located in Manhattan among five boroughs. Borough code for Manhattan: '1'.
- Designate coordinate points as geometry data to let GIS (QGIS) read and render the data. Python modules: Geopandas and shapley.
- Save them as .csv or shapefile.
- Refer to file "Manhattan_Hydrants.ipynb"

### QGIS
[Render geometry data in QGIS and select 2x2 sample area]
- Import trimmed manhattan data. 
- Go to PLUTO 'https://chriswhong.github.io/plutoplus/#'. 1) Choose Area. (2x2) 2) Draw a polygon of desired area. 3) Download and import it into QGIS as a base map. Note if the coordinate system is corresponding. (epsg)
- Make sure the base map goes to the bottom. 
- Select each geometry data and draw a polygon following the base map. Save as selected area into csv files. (Hand drawing is availble in QGIS)
- Per each layer, you can select icon color or design.

I would rather recommend going to the file "Manhattan_Access.qgz", select each layer and right click -> Export -> Save feature as -> select file type (could be anything, geojson, csv, and shapefile) -> select the location you want to save (must direct the location) -> name the file and save. The Qgis project includes all the data for Manhattan area.

Recomended Tutorials:

"https://www.youtube.com/watch?v=Yxkh2f-3Bj8&list=WL&index=12"
"https://www.youtube.com/watch?v=-7v5qfJYWxA&list=LL&index=63"
"https://www.youtube.com/watch?v=sGMTJeE1C-Y&list=LL&index=64"

### UNITY3D
[Install UnityHub and VisualStudio]
- https://unity3d.com/get-unity/download
- https://visualstudio.microsoft.com/

Set an arbitrary point of Lat/Long of the center of sample 2 by 2 area and get the difference of each point. Divide that by 10 or any number that would appropriate to shrink the size and render them in Unity. 

Turn the direction by 29 degrees since Manhattan's whole grid is titled 29 degrees to the northeast. 

Recomended Tutorials:

"https://www.youtube.com/watch?v=pwZpJzpE2lQ" Overall beginer level tutorial.
"https://docs.unity3d.com/ScriptReference/Vector3-ctor.html" Unity's vector constructor. In Unity, y and z are opposite. Vector y stands for the vertical direction.
"https://docs.unity3d.com/ScriptReference/GameObject-ctor.html" Unity's gameobject constructor.

Next task: Write c# scripts to automatically read csv files of shrank coordinates and create game object with different color and shape based on the types of infrastructures.
![image](https://user-images.githubusercontent.com/97256415/177247877-2eb79e8d-0c14-4cd7-963b-96b430357d80.png)

