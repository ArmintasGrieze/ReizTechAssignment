using System;
using System.Collections.Generic;

namespace ReizTech2
{
    internal class Branch
    {
        public List<Branch> Branches;

        public void CreateBranches()
        {
            Branches = new List<Branch>()
                {
                new Branch()
                {
                    Branches = new List<Branch>()
                        {
                        new Branch()
                        }
                },
                new Branch()
                {
                    Branches = new List<Branch>()
                        {
                        new Branch()
                        {
                            Branches = new List<Branch>()
                            {
                                new Branch()
                            }
                        },
                        new Branch()
                        {
                            Branches = new List<Branch>
                            {
                                new Branch()
                                {
                                    Branches = new List<Branch>()
                                    {
                                    new Branch()
                                    }
                                },
                                new Branch(),
                            }
                        },
                        new Branch()
                        }
                }
                };
        }

        public int CalculateDepth(Branch branch)
        {
            if (branch.Branches == null)
            {
                return 0;
            }

            var depth = 1;
            foreach (Branch item in branch.Branches)
            {
                depth = Math.Max(depth, CalculateDepth(item));
            }

            return depth + 1;
        }
    }
}