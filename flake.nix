{
  description = ".NET Development Shell";

  inputs.nixpkgs.url = "github:NixOS/nixpkgs/nixos-25.11";

  outputs = { self, nixpkgs }:
    let
      system = "x86_64-linux";
      pkgs = nixpkgs.legacyPackages.${system};

      dotnet = pkgs.dotnetCorePackages.combinePackages (with pkgs.dotnetCorePackages; [
        sdk_10_0-bin
        sdk_9_0-bin
      ]);
    in
    {
      devShells.${system}.default = pkgs.mkShell {
        packages = [ dotnet ];
      };
    };
}
