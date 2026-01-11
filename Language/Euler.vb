Enum Euler
const V = Vertice
var E = Edge 
let F = Face
V - E + F = 2
End Enum

Module polyhedron
V = 4,E = 4,F = 4 As New Tetrahedron 
V = 8,E = 12,F = 6 As New Hexahedron 
V = 6,E = 12,F = 8 As New Octahedron 
V = 20,E = 30,F = 12 As New Dodecahedron 
V = 12,E = 30,F = 20 As New Icosahedron 
End Module

Function Surface
    Sub Topology
    End Sub
End Function

Function Volume
    Sub Fractal
    End Sub
End Function