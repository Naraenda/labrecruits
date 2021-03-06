/*
This program has been developed by students from the bachelor Computer Science
at Utrecht University within the Software and Game project course.

©Copyright Utrecht University (Department of Information and Computing Sciences)
*/

using UnityEngine;

/// <summary>
/// Minimized container for a navmesh containing just the vertices and indices.
/// </summary>
public struct NavMeshContainer
{
    public Vector3[] vertices;
    public int[] indices;

    public NavMeshContainer(Vector3[] navVertices, int[] navIndices)
    {
        vertices = navVertices;
        indices = navIndices;
    }
}
