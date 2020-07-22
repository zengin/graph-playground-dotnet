# graph-playground-dotnet

Disclaimer: this is a personal playground to test Microsoft Graph features, it is not official documentation.

## LinqPad: How to switch between V1 and Beta quickly
LinqPad 6 allows loading other query files within a query file. So one can create two init files:
- **BetaInit.linq**, referencing Microsoft.Graph.Beta nuget package
  - e.g. `linqpad/init/BetaInit.linq`
- **V1Init.linq**, referencing Microsoft.Graph nuget package
  - e.g. `linqpad/init/V1Init.linq`

Assuming `init` folder is at the root of LinqPad's `My Queries` folder, then it can be loaded by:
```
#load "init/V1Init.linq"
```

When the load statement is changed, referenced SDK switches automatically to the correct package. See `linqpad/common/CommonPlayGround.linq` for an example.