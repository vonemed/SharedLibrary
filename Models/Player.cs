#if UNITY_EDITOR
using System;
#endif

namespace SharedLibrary.Models
{
    public class Player
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = "";
    }
}