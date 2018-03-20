using System;
using System.Collections.Generic;
using System.Text;

public class TyreFactory
{
    public Tyre GetTyre(List<string> inputData)
    {
        string type;
        double hardness, grip;

        type = inputData[0];
        hardness = double.Parse(inputData[1]);

        switch (type)
        {
            case "Hard":

                return new HardTyre(hardness);

            case "Ultrasoft":

                grip = double.Parse(inputData[2]);

                return new UltrasoftTyre(hardness, grip);

            default:
                throw new ArgumentException(Messages.missingTyreType);
        }
    }
}
