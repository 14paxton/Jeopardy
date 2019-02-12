﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jeopardy
{
    public class DB_Insert
    {
        readonly static OleDbConnection conn = DB_Conn.GetGamesConnection();

        public static int? InsertGame(Game newGame)
        {
            string insertStatement =
                "INSERT INTO games(GameName, QuestionTimeLimit, NumCategories, NumQuestionsPerCategory) "
              + "VALUES (@gameName, @questionTimeLimit, @numCategories, @numQuestionsPerCategory)";

            string identityStatement = "SELECT @@Identity";

            OleDbCommand insertCommand = new OleDbCommand(insertStatement, conn);

            insertCommand.Parameters.AddWithValue("@gameName", newGame.GameName);
            insertCommand.Parameters.AddWithValue("@questionTimeLimit", Convert.ToInt32(newGame.QuestionTimeLimit.TotalSeconds));
            insertCommand.Parameters.AddWithValue("@numCategories", newGame.NumCategories);
            insertCommand.Parameters.AddWithValue("@numQuestionsPerCategory", newGame.NumQuestionsPerCategory);

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                insertCommand.ExecuteNonQuery();

                insertCommand.CommandText = identityStatement;
                newGame.Id = Convert.ToInt32(insertCommand.ExecuteScalar());

                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

                if (newGame.Categories != null && newGame.Categories.Count > 0)
                {
                    foreach (Category c in newGame.Categories)
                    {
                        c.GameId = (int)newGame.Id;
                        c.Id = InsertCategory(c);
                    }
                }
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Database exception\n\n" + ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("General exception\n\n" + ex.ToString());
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return newGame.Id;
        }

        public static int? InsertCategory(Category newCategory)
        {
            string insertStatement =
                "INSERT INTO categories(GameId, [Index], Title, Subtitle) "
              + "VALUES (@gameId, @index, @title, @subtitle)";

            string identityStatement = "SELECT @@Identity";

            OleDbCommand insertCommand = new OleDbCommand(insertStatement, conn);

            insertCommand.Parameters.AddWithValue("@gameId", newCategory.GameId);
            insertCommand.Parameters.AddWithValue("@index", newCategory.Index);
            insertCommand.Parameters.AddWithValue("@title", newCategory.Title);
            insertCommand.Parameters.AddWithValue("@subtitle", newCategory.Subtitle);

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                insertCommand.ExecuteNonQuery();

                insertCommand.CommandText = identityStatement;
                newCategory.Id = Convert.ToInt32(insertCommand.ExecuteScalar());

                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

                if (newCategory.Questions != null && newCategory.Questions.Count > 0)
                {
                    foreach (Question q in newCategory.Questions)
                    {
                        q.CategoryId = (int)newCategory.Id;
                        q.Id = InsertQuestion(q);
                    }
                }
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Database exception\n\n" + ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("General exception\n\n" + ex.ToString());
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return newCategory.Id;
        }

        public static int? InsertQuestion(Question newQuestion)
        {
            string insertStatement =
                "INSERT INTO questions(CategoryId, Type, QuestionText, Answer, Weight) "
              + "VALUES (@categoryId, @type, @questionText, @answer, @weight)";

            string identityStatement = "SELECT @@Identity";

            OleDbCommand insertCommand = new OleDbCommand(insertStatement, conn);

            insertCommand.Parameters.AddWithValue("@categoryId", newQuestion.CategoryId);
            insertCommand.Parameters.AddWithValue("@type", newQuestion.Type);
            insertCommand.Parameters.AddWithValue("@questionText", newQuestion.QuestionText);
            insertCommand.Parameters.AddWithValue("@answer", newQuestion.Answer);
            insertCommand.Parameters.AddWithValue("@weight", newQuestion.Weight);

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                insertCommand.ExecuteNonQuery();

                insertCommand.CommandText = identityStatement;
                newQuestion.Id = Convert.ToInt32(insertCommand.ExecuteScalar());

                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

                if (newQuestion.Choices != null && newQuestion.Choices.Count > 0)
                {
                    foreach (Choice c in newQuestion.Choices)
                    {
                        c.QuestionId = (int)newQuestion.Id;
                        c.Id = InsertChoice(c);
                    }
                }
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Database exception\n\n" + ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("General exception\n\n" + ex.ToString());
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return newQuestion.Id;
        }

        public static int? InsertChoice(Choice newChoice)
        {
            string insertStatement =
                "INSERT INTO choices(QuestionId, [Index], ChoiceText) "
              + "VALUES (@questionId, @index, @choiceText)";

            string identityStatement = "SELECT @@Identity";

            OleDbCommand insertCommand = new OleDbCommand(insertStatement, conn);

            insertCommand.Parameters.AddWithValue("@questionId", newChoice.QuestionId);
            insertCommand.Parameters.AddWithValue("@index", newChoice.Index);
            insertCommand.Parameters.AddWithValue("@choiceText", newChoice.Text);

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                insertCommand.ExecuteNonQuery();

                insertCommand.CommandText = identityStatement;
                newChoice.Id = Convert.ToInt32(insertCommand.ExecuteScalar());
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Database exception\n\n" + ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("General exception\n\n" + ex.ToString());
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return newChoice.Id;
        }
    }
}