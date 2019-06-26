# DataFlattener

Flatten deeply nested JSON or XML objects using XPath or JsonPath

Target Platform : .Net Standard 2.0 / .NET Core 3.0

## Example
### JSON Data Flattening
#### Input
```json
[
  {
    "id": "beedff9e-be8a-4d88-8da3-c610b8b12ca5",
    "name": "beedff9e-be8a-4d88-8da3-c610b8b12ca5",
    "range": {
      "start": {
        "page": 1,
        "x": 131.56,
        "y": 430.481
      },
      "end": {
        "page": 1,
        "x": 483.798,
        "y": 526.923
      }
    }
  },
  {
    "id": "3642c440-07d2-4cb3-a567-eb6223d4bff9",
    "name": "3642c440-07d2-4cb3-a567-eb6223d4bff9",
    "range": {
      "start": {
        "page": 1,
        "x": 612.0,
        "y": 384.548
      },
      "end": {
        "page": 1,
        "x": 792.0,
        "y": 526.548
      }
    }
  }
]
```
(See DataSamples/Json/sample01.json)
#### Mapping
|DataSourcePath|Name
|------|---|
|id|id|
|name|name|
|range.start.page|range_start_page|
|range.start.x|range_start_x|
|range.start.y|range_start_y|
|range.end.page|range_end_page|
|range.end.x|range_end_x|
|range.end.y|range_end_y|

(See DataTableMapFactory.CreateTestMap() in DataFlattener.Core Project)
#### Output
```json
[
  {
    "id": "beedff9e-be8a-4d88-8da3-c610b8b12ca5",
    "name": "beedff9e-be8a-4d88-8da3-c610b8b12ca5",
    "range_start_page": "1",
    "range_start_x": "131,56",
    "range_start_y": "430,481",
    "range_end_page": "1",
    "range_end_x": "483,798",
    "range_end_y": "526,923"
  },
  {
    "id": "3642c440-07d2-4cb3-a567-eb6223d4bff9",
    "name": "3642c440-07d2-4cb3-a567-eb6223d4bff9",
    "range_start_page": "1",
    "range_start_x": "612",
    "range_start_y": "384,548",
    "range_end_page": "1",
    "range_end_x": "792",
    "range_end_y": "526,548"
  }
]
```

### XML Data Flattening
(Work In Progress)

## Projects

|Name|Description|Type|TargetFramework
|------|---|---|---|
|Core|Common Components|Class Library|netstandard2.0
|Csv|Components for DataTable serialization to CSV |Class Library|netstandard2.0
|Json|Components for DataTable serialization to JSON |Class Library|netstandard2.0
|Xml|Components for DataTable serialization to XML |dll|netstandard2.0
|TestConsoleApp|Test Console App |Console Application|.Net Framework 4.7.2
|WebApp.Shared|Blazor Client/Server Shared | |netstandard2.0
|WebApp.Server|Blazor Server | |netstandard2.0
|WebApp.Client|Blazor Client | |netstandard2.0

## Getting Started
### Prerequisites
- Visual Studio 2019
- Latest .NET Core 3.0 Preview SDK

## Authors

* **Amael BERTEAU**

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details

## Credits
* [Newtonsoft.Json](https://github.com/JamesNK/Newtonsoft.Json)
* [CsvHelper](https://github.com/JoshClose/CsvHelper)