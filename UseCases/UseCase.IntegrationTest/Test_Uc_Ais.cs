
using NUnit.Framework;
using System;
using System.Data;
using System.IO;

namespace Asc
{
    class Test_Uc_Ais
    {
        [Test]
        public void Test_Uc_Ais_FrTg_2005_2019()
        {
            // Arrange
            Uc_Ais Uc_Ais = new Uc_Ais();
            string ResultFolderPath = @"D:\Result\";
            Uc_Ais.CpaFilePath = ResultFolderPath + @"Cpa\" + "Result_Cpa01" + ".csv";
            Uc_Ais.SpaFilePath = ResultFolderPath + @"Spa\" + "Result_Spa_Tg" + ".csv";
            Uc_Ais.AisFilePath = ResultFolderPath + @"Ais\" + "Result_Ais_Tg_2005_2019" + ".csv";
            // Set Time Range Here: 
            Uc_Ais.CpStartDate = new DateTime(2005, 10, 1);
            Uc_Ais.CpEndDate = new DateTime(2019, 9, 30);

            // Act
            bool result;
            result = Uc_Ais.Run();

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void Test_Uc_Ais_FrTg_2006_2020()
        {
            // Arrange
            Uc_Ais Uc_Ais = new Uc_Ais();
            string ResultFolderPath = @"D:\Result\";
            Uc_Ais.CpaFilePath = ResultFolderPath + @"Cpa\" + "Result_Cpa01" + ".csv";
            Uc_Ais.SpaFilePath = ResultFolderPath + @"Spa\" + "Result_Spa_Tg" + ".csv";
            Uc_Ais.AisFilePath = ResultFolderPath + @"Ais\" + "Result_Ais_Tg_2006_2020" + ".csv";
            // Set Time Range Here: 
            Uc_Ais.CpStartDate = new DateTime(2006, 10, 1);
            Uc_Ais.CpEndDate = new DateTime(2020, 9, 30);

            // Act
            bool result;
            result = Uc_Ais.Run();

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void Test_Uc_Ais_FrTg_2007_2021()
        {
            // Arrange
            Uc_Ais Uc_Ais = new Uc_Ais();
            string ResultFolderPath = @"D:\Result\";
            Uc_Ais.CpaFilePath = ResultFolderPath + @"Cpa\" + "Result_Cpa01" + ".csv";
            Uc_Ais.SpaFilePath = ResultFolderPath + @"Spa\" + "Result_Spa_Tg" + ".csv";
            Uc_Ais.AisFilePath = ResultFolderPath + @"Ais\" + "Result_Ais_Tg_2007_2021" + ".csv";
            // Set Time Range Here: 
            Uc_Ais.CpStartDate = new DateTime(2007, 10, 1);
            Uc_Ais.CpEndDate = new DateTime(2021, 9, 30);

            // Act
            bool result;
            result = Uc_Ais.Run();

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void Test_Uc_Ais_FrTg_2008_2022()
        {
            // Arrange
            Uc_Ais Uc_Ais = new Uc_Ais();
            string ResultFolderPath = @"D:\Result\";
            Uc_Ais.CpaFilePath = ResultFolderPath + @"Cpa\" + "Result_Cpa01" + ".csv";
            Uc_Ais.SpaFilePath = ResultFolderPath + @"Spa\" + "Result_Spa_Tg" + ".csv";
            Uc_Ais.AisFilePath = ResultFolderPath + @"Ais\" + "Result_Ais_Tg_2008_2022" + ".csv";
            // Set Time Range Here: 
            Uc_Ais.CpStartDate = new DateTime(2008, 10, 1);
            Uc_Ais.CpEndDate = new DateTime(2022, 9, 30);

            // Act
            bool result;
            result = Uc_Ais.Run();

            // Assert
            Assert.IsTrue(result);
        }
        [Test]
        public void Test_Uc_Ais_FrRr_2005_2019()
        {
            // Arrange
            Uc_Ais Uc_Ais = new Uc_Ais();
            string ResultFolderPath = @"D:\Result\";
            Uc_Ais.CpaFilePath = ResultFolderPath + @"Cpa\" + "Result_Cpa01" + ".csv";
            Uc_Ais.SpaFilePath = ResultFolderPath + @"Spa\" + "Result_Spa_Rr" + ".csv";
            Uc_Ais.AisFilePath = ResultFolderPath + @"Ais\" + "Result_Ais_Rr_2005_2019" + ".csv";
            // Set Time Range Here: 
            Uc_Ais.CpStartDate = new DateTime(2005, 10, 1);
            Uc_Ais.CpEndDate = new DateTime(2019, 9, 30);

            // Act
            bool result;
            result = Uc_Ais.Run();

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void Test_Uc_Ais_FrRr_2006_2020()
        {
            // Arrange
            Uc_Ais Uc_Ais = new Uc_Ais();
            string ResultFolderPath = @"D:\Result\";
            Uc_Ais.CpaFilePath = ResultFolderPath + @"Cpa\" + "Result_Cpa01" + ".csv";
            Uc_Ais.SpaFilePath = ResultFolderPath + @"Spa\" + "Result_Spa_Rr" + ".csv";
            Uc_Ais.AisFilePath = ResultFolderPath + @"Ais\" + "Result_Ais_Rr_2006_2020" + ".csv";
            // Set Time Range Here: 
            Uc_Ais.CpStartDate = new DateTime(2006, 10, 1);
            Uc_Ais.CpEndDate = new DateTime(2020, 9, 30);

            // Act
            bool result;
            result = Uc_Ais.Run();

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void Test_Uc_Ais_FrRr_2007_2021()
        {
            // Arrange
            Uc_Ais Uc_Ais = new Uc_Ais();
            string ResultFolderPath = @"D:\Result\";
            Uc_Ais.CpaFilePath = ResultFolderPath + @"Cpa\" + "Result_Cpa01" + ".csv";
            Uc_Ais.SpaFilePath = ResultFolderPath + @"Spa\" + "Result_Spa_Rr" + ".csv";
            Uc_Ais.AisFilePath = ResultFolderPath + @"Ais\" + "Result_Ais_Rr_2007_2021" + ".csv";
            // Set Time Range Here: 
            Uc_Ais.CpStartDate = new DateTime(2007, 10, 1);
            Uc_Ais.CpEndDate = new DateTime(2021, 9, 30);

            // Act
            bool result;
            result = Uc_Ais.Run();

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void Test_Uc_Ais_FrRr_2008_2022()
        {
            // Arrange
            Uc_Ais Uc_Ais = new Uc_Ais();
            string ResultFolderPath = @"D:\Result\";
            Uc_Ais.CpaFilePath = ResultFolderPath + @"Cpa\" + "Result_Cpa01" + ".csv";
            Uc_Ais.SpaFilePath = ResultFolderPath + @"Spa\" + "Result_Spa_Rr" + ".csv";
            Uc_Ais.AisFilePath = ResultFolderPath + @"Ais\" + "Result_Ais_Rr_2008_2022" + ".csv";
            // Set Time Range Here: 
            Uc_Ais.CpStartDate = new DateTime(2008, 10, 1);
            Uc_Ais.CpEndDate = new DateTime(2022, 9, 30);

            // Act
            bool result;
            result = Uc_Ais.Run();

            // Assert
            Assert.IsTrue(result);
        }
    }
}
